class ListNode {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}

class SinglyLinkedList {
    constructor() {
        this.head = null;
        this.tail = null;
    }

    addToBack(value) {
        var new_node = new ListNode(value);
        if (this.head == null) {
            this.head = new_node;
            this.tail = new_node;
        } else {
            this.tail.next = new_node;
            this.tail = new_node;
        }
    }

    display() {
        if (this.head == null) {
            return null;
        }
        var values = this.head.value;
        var runner = this.head.next;

        while (runner != null) {
            values += " - " + runner.value;
            runner = runner.next;
        }
        return values;
    }

    //     reverse() {
    //         let current = this.head;
    //         let next = null;
    //         let previous = null;
    //         while (current != null) {

    //             next = current.next;
    //             current.next = previous;
    //             previous = current;
    //             current = next;
    //         }
    //         this.head = previous;
    //     }
    // }

    // loopCreate(); {
    //     let runner = this.head;
    //     let prev = null;
    //     while (runner) {
    //         if (runner.next == null) {
    //             runner.next = runner.value;
    //         }
    //     }
    // }

    // Singly Linked List Has Loop
    // Some dastardly coding has left you with a loop in your singly linked list!(Meaning your
    //     while loop will run forever!) --It 's up to you to figure out if it'
    // s just a really long list or your coworker has created a loop in your list!
    // Return true if a loop is found, false if one is not

    // Break loop
    // After identifying that a loop has been found, break it

    var new_sll = new SinglyLinkedList();
    new_sll.addToBack("Disneyland");
    new_sll.addToBack("Las Vegas");
    new_sll.addToBack("Grand Canyon");
    new_sll.addToBack("Times Square");
    new_sll.addToBack("Mount Rushmore");
    console.log(new_sll.display());

    new_sll.reverse();
    console.log(new_sll.display());