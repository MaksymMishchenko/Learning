namespace CarNoticeApp
{
    class CarNotice
    {
        private const string _ENGINE_IS_STARTED_MESSAGE = "Двигатель запущен!";
        private const string _ATTEMPT_TO_START_ENGINE_MESSAGE = "Завожу двигатель";
        private const string _ENGINE_HAS_ALREADY_STARTED_MESSAGE = "Лапоть, двигатель уже запущен";
        private const string _ATTEMPT_TO_DRIVE_MESSAGE = "Тапку в пол";
        private const string _DRIVE_MESSAGE = "Поехали";
        private const string _DRIVE_ERROR_MESSAGE = "Лапоть, сначала заведи двигатель";

        private CarLogger _carLogger;
        private bool _IsEngineStarted;

        public CarNotice(CarLogger carLogger)
        {
            _carLogger = carLogger;
        }

        public void StartEngine()
        {
            _carLogger.Info(_ATTEMPT_TO_START_ENGINE_MESSAGE);

            if (_IsEngineStarted)
            {
                _carLogger.Warning(_ENGINE_HAS_ALREADY_STARTED_MESSAGE);
            }
            else
            {
                _IsEngineStarted = true;
                _carLogger.Info(_ENGINE_IS_STARTED_MESSAGE);
            }
        }

        public void Drive()
        {
            _carLogger.Info(_ATTEMPT_TO_DRIVE_MESSAGE);

            if (_IsEngineStarted)
            {
                _carLogger.Info(_DRIVE_MESSAGE);
            }
            else
            {
                _carLogger.Error(_DRIVE_ERROR_MESSAGE);
            }
        }
    }
}
