﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using DataLayer.EfClassesSql;
using GenericServices;

namespace ServiceLayer.Books.Dtos
{
    public class DeleteBookDto : ILinkToEntity<Book>
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorsOrdered { get; set; }
    }
}