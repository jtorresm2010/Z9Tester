using System;

namespace Z9Tester.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }


    public class MockUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public float ND { get; set; }
    }

    public class MockObject
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}