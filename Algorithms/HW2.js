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
    addToFront(value) {
        var new_node = new ListNode(value);

        if (this.head == null) {
            this.head = new_node;
            this.tail = new_node;
        } else {
            new_node.next = this.head;
            this.head = new_node;
        }
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
    contains(target) {
        var runner = this.head;

        while (runner != null) {
            if (runner.value == target) {
                return true;
            }
            runner = runner.next;
        }
        return false;
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

    removeFront() {
        var temp = this.head;
        this.head = this.head.next;
        temp = null;
    }

    removeBack() {

    }
}

// reverse(); {
//     var currentNode = this.head;
//     var nextNode = this.head.next;
//     var prevNode = null;
//     if (!this.head || this.head.next == null) {
//         return this.head;
//     }


//     while (currentNode) {
//         nextNode = currentNode.next;
//         currentNode.next = prevNode;
//         prevNode = currentNode;
//         currentNode = nextNode;
//     }
//     this.head = prevNode;
// }

var new_sll = new SinglyLinkedList();
new_sll.addToBack("Disneyland");
new_sll.addToBack("Las Vegas");
new_sll.addToBack("Mount Rushmore");
new_sll.addToBack("Times Square");
console.log(new_sll.display());
console.log(new_sll.reverse());

// console.log(new_sll.removeFront());


// function reverse(head) {
//     if (!head || head.next) {
//         return head;
//     }

//     let temp = reverse(head.next);
//     head.next.next = head;
//     return temp;

// }
// sll.printSinglyLinkedListReverse(2, 4, 8, 1, 5);

// class Node {
//     constructor(value) {
//         this.val = value;
//         this.next = null;
//     }
// }

// class SinglyLinkedList {
//     constructor() {
//         this.head = null;
//         this.tail = null;
//     }
// }
// var reverse = function(head){
//     let prev = null;
//     let current = head;
//     let nextTemp=curr.next;

//     while(current!=null){
//         nextTemp = curr.next; 
//         curr.next = prev; 
//         prev = curr;  
//         curr = nextTemp;
//     }
//     return prev;
//     };