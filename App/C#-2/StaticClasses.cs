namespace App
{
    // You can't declare instance methods, properties, events or constructors in a static class but you can have nested instance classes.
    public static class StaticClasses
    {
        public class NestedInstanceClass {
            private int InstanceProperty { get; set; }
            public void InstanceMethod() {}
        }

    }
}
