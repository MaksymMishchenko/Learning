﻿using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsStoreAPP.Models.ViewModels;

namespace SportsStoreAPP.TagHelpers
{
    public static class PagingHelpers
    {
        public static IHtmlContent PagingLinks(this IHtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            var result = new TagBuilder("div");

            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                var tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml.Append(i.ToString());

                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                }

                result.InnerHtml.AppendHtml(tag);
            }

            return result;
        }
    }
}