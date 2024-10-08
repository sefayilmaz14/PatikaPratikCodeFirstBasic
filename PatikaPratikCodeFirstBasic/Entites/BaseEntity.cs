﻿namespace PatikaPratikCodeFirstBasic.Entites
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public  bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
