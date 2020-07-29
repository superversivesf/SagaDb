﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SagaDb.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string BookId { get; set; }
        public string BookTitle { get; set; }
        public bool GoodReadsFetchTried { get; set; }
        public string GoodReadsDescription { get; set; }
        public string GoodReadsLink { get; set; }
        public string GoodReadsTitle { get; set; }
        public string GoodReadsCoverImage { get; set; }
        public string BookLocation { get; set; }
    }

    public class BookEqualityComparer : EqualityComparer<Book>
    {
        public override bool Equals([AllowNull] Book x, [AllowNull] Book y)
        {
            if (x.BookId.Equals(y.BookId))
                return true;
            return false;
        }

        public override int GetHashCode([DisallowNull] Book obj)
        {
            return obj.BookId.GetHashCode();
        }
    }
}
