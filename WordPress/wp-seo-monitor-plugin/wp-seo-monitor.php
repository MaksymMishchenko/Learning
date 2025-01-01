<?php

/**
 * Plugin Name: WP SEO Monitor
 * Description: Плагін для аналізу SEO-даних за допомогою Google Custom Search JSON API.
 * Version: 1.0
 * Author: Ваше ім'я
 */

if ( ! defined( 'ABSPATH' ) ) exit; // Забороняємо прямий доступ до файлу

// Реєстрація сторінки плагіна в адмінці
function wp_seo_monitor_add_admin_menu() {
    add_menu_page(
        'SEO Monitor',          // Назва сторінки
        'SEO Monitor',          // Назва у меню
        'manage_options',       // Рівень доступу
        'wp-seo-monitor',       // Слаг
        'wp_seo_monitor_page'   // Callback функція
    );
}
add_action( 'admin_menu', 'wp_seo_monitor_add_admin_menu' );

function wp_seo_monitor_page() {
    // Ініціалізація змінної для сайту
    $website = isset($_POST['website']) ? sanitize_text_field($_POST['website']) : '';
    $keyword = isset($_POST['keyword']) ? sanitize_text_field($_POST['keyword']) : '';
    ?>
    <h1>SEO Analyzer</h1>
    <form method="post">
        <label for="website">Сайт:</label>
        <input type="text" name="website" id="website" required value="<?php echo esc_attr($website); ?>">                
        <br>
        <label for="keyword">Ключова фраза:</label>
        <input type="text" name="keyword" id="keyword" required value="<?php echo esc_attr($keyword); ?>">
        <br>
        <button type="submit">Аналізувати</button>
    </form>
    <?php

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        $website = sanitize_text_field($_POST['website']);        
        $keyword = sanitize_text_field($_POST['keyword']);

        // Очищення URL
        $cleanedWebsite = check_url($website);

        $result = analyze_position($cleanedWebsite, $keyword);

        if ($result !== false) {
            echo "<h2>Результати для сайту {$website} за запитом '{$keyword}' на " . date('d.m.Y') . "</h2>";
            echo "<p>Позиція сайту: {$result}</p>";
        } else {
            echo "<h2>Сайт не знайдено у видачі за запитом '{$keyword}'.</h2>";
        }
    }   
}

function analyze_position($website, $keyword) {
    $apiKey = ''; // Замініть на ваш API ключ
    $cx = ''; // Замініть на ваш CX ID

    $start = 1; // Починається з 1, для другої сторінки це буде 11, для третьої — 21.

    // Ітерація по сторінках
    for ($i = 0; $i < 5; $i++) { // Перевіряємо до 5 сторінок результатів
        $url = "https://www.googleapis.com/customsearch/v1?" . 
               "q=" . urlencode($keyword) . 
               "&cx={$cx}" . 
               "&key={$apiKey}" . 
               "&gl=ua" . 
               "&hl=uk" . 
               "&start={$start}";

        $response = wp_remote_get($url);

        if (is_wp_error($response)) {
            return false;
        }

        $data = json_decode(wp_remote_retrieve_body($response), true);

        if (isset($data['items'])) {
            $foundPosition = null;
            // Перевірка наявності сайту в кожному результаті
            foreach ($data['items'] as $index => $item) {
                if (strpos($item['link'], $website) !== false) {
                    $foundPosition = $start + $index; // Позиція сайту у видачі
                    break;
                }
            }

            if ($foundPosition) {
                return $foundPosition;
            }
        }

        $start += 10; // Переходимо до наступної сторінки
    }

    return false; // Якщо сайт не знайдено на жодній зі сторінок
}

function check_url($url) {
    // Видаляємо протокол та шлях, залишаючи лише домен
    $parsedUrl = parse_url($url);
    if (isset($parsedUrl['host'])) {
        return strtolower($parsedUrl['host']); // Повертаємо лише хост
    } elseif (isset($parsedUrl['path'])) {
        return strtolower($parsedUrl['path']); // У разі, якщо передано лише шлях
    }
    return strtolower($url); // Якщо нічого не розпізнано, повертаємо оригінальний URL
}
?>
