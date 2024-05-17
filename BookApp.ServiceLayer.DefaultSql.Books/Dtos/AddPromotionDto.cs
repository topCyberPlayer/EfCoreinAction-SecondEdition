// Copyright (c) 2020 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using BookApp.Domain.Books;
using GenericServices;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookApp.ServiceLayer.DefaultSql.Books.Dtos
{
    public class AddPromotionDto : ILinkToEntity<Book>
    {
        [HiddenInput]
        public int BookId { get; set; }

        public string Title { get; set; }

        public decimal OrgPrice { get; set; }
        public decimal ActualPrice { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string PromotionalText { get; set; }
    }

}