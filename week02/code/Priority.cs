public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        //var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);


        // Test Cases

        // Test 1
        // Scenario: A queue with accending priority values mixed through the list
        // Expected Result: F, E, D, G, A, C, B
        Console.WriteLine("Test 1");
        var letters = new PriorityQueue();
        letters.Enqueue("A", 3);
        letters.Enqueue("B", 1);
        letters.Enqueue("C", 2);
        letters.Enqueue("D", 5);
        letters.Enqueue("E", 7);
        letters.Enqueue("F", 9);
        letters.Enqueue("G", 4);
        // Console.WriteLine(letters); 
        for(int i = 0; i <= 6; i++) {
            Console.WriteLine(letters.Dequeue());
        }
        // Defect(s) Found: 
            //Dequeue function would get the item with the highest priority but would not removed it
            //Dequeue function for loop did not iterate though every item in the list

        Console.WriteLine("---------");



        // Test 2
        // Scenario: A queue where some priority vaules are of the same priority
        // Expected Result: E, B, D, G, A, C, F
        Console.WriteLine("Test 2");
        letters = new PriorityQueue();
        letters.Enqueue("A", 5);
        letters.Enqueue("B", 9);
        letters.Enqueue("C", 4);
        letters.Enqueue("D", 6);
        letters.Enqueue("E", 10);
        letters.Enqueue("F", 3);
        letters.Enqueue("G", 6);
        // Console.WriteLine(letters); 
        for(int i = 0; i <= 6; i++) {
            Console.WriteLine(letters.Dequeue());
        }
        // Defect(s) Found: 
            //The ">=" in the if statment comparing the higher priority indexes needs to be ">" so if
            //there are two item with the same priority the one closest to the begining of the list is selected 

        Console.WriteLine("---------");



        // Test 3
        // Scenario: A queue where some of the priority values are negitive 
        // Expected Result: C, G, A, F, E, B, D
        Console.WriteLine("Test 3");
        letters = new PriorityQueue();
        letters.Enqueue("A", 6);
        letters.Enqueue("B", 1);
        letters.Enqueue("C", 9);
        letters.Enqueue("D", -8);
        letters.Enqueue("E", 2);
        letters.Enqueue("F", 4);
        letters.Enqueue("G", 7);
        // Console.WriteLine(letters); 
        for(int i = 0; i <= 6; i++) {
            Console.WriteLine(letters.Dequeue());
        }
        // Defect(s) Found: 
            //None

        Console.WriteLine("---------");



        // Test 4
        // Scenario: Double and Triple digit numbers both negitive and positive
        // Expected Result: F, D, B, C, E, G, A
        Console.WriteLine("Test 4");
        letters = new PriorityQueue();
        letters.Enqueue("A", -150);
        letters.Enqueue("B", 50);
        letters.Enqueue("C", -34);
        letters.Enqueue("D", 100);
        letters.Enqueue("E", -64);
        letters.Enqueue("F", 125);
        letters.Enqueue("G", -143);
        // Console.WriteLine(letters); 
        for(int i = 0; i <= 6; i++) {
            Console.WriteLine(letters.Dequeue());
        }
        // Defect(s) Found: 
            //none

        Console.WriteLine("---------");


        // Test 5
        // Scenario: Trying to Dequeue an item from the list when the list is empty
        // Expected Result: the error "The queue is empty." should show 
        Console.WriteLine("Test 5");
        letters = new PriorityQueue();

        Console.WriteLine(letters.Dequeue());
        Console.WriteLine(letters.Dequeue()); 
        Console.WriteLine(letters.Dequeue());  

        // Defect(s) Found: 
            //None
    }
}