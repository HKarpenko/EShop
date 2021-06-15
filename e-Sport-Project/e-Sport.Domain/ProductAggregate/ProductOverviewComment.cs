using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;
using e_Sport.Domain.UserAggregate;

namespace e_Sport.Domain.ProductAggregate
{
    public class ProductOverviewComment : IEntity
    {
        private static int counter = 1;
        public ProductOverviewComment()
        {
            Id = counter;
            counter++;
        }
        public ProductOverviewComment(string text, User author)
        {
            Text = text;
            Author = author;
            Id = counter;
            counter++;
        }
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
        public virtual User Author { get; set; }
        public virtual int Likes { get; set; }
        public virtual int Dislikes { get; set; }
        public virtual void Like()
        {
            Likes++;
        }
        public virtual void Dislike()
        {
            Dislikes++;
        }

    }
}
