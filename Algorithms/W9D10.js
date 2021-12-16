class BNode {
    constructor(value) {
        this.value = value;
        this.right = null;
        this.left = null;
    }
}

// Binary Search Tree class
class BST {
    constructor() {
            // Just like with head or tail we can't assume there is a value already so we start it at null
            this.root = null;
        }
        // Checking to see if the tree is empty
    isEmpty() {
        return this.root == null;
    }

    // Add to tree
    // Case 1: there is nothing in the tree -> then the value to add becomes the root
    // Case 2: this is something, so we have to figure out which direction to go
    // Ask which direction to go, we need a while loop to allow us to keep asking this question until we hit a null
    // Assuming we are passing a numeric value in, NOT a node
    add(newVal) {
        const node = new BNode(newVal);
        // First, check if it's empty
        if (this.isEmpty()) {
            this.root = node;
        } else {
            let runner = this.root;
            while (true) {
                // check if the value is smaller
                if (runner.value > newVal) {
                    // Need to check if there is null to the left
                    if (runner.left == null) {
                        runner.left = node;
                        return this;
                    }
                    // We need to go to the left
                    runner = runner.left;
                } else {
                    // runner is SMALLER than our value
                    // Need to check if there is null to the right
                    if (runner.right == null) {
                        runner.right = node;
                        return this;
                    }
                    // we need to go to the right
                    runner = runner.right;
                }
            }
        }
    }

    // How would we get the smallest value from this BST?
    min() {
        // the value is located at the very bottom left
        // Need a while loop to take us down to the leftmost value
        // Edge case: there is nothing in the tree, therefore there is no leftmost value
        if (this.isEmpty()) {
            return null;
        } else {
            let runner = this.root;
            while (runner.left) {
                runner = runner.left;
            }
            return runner.value;
        }
    }

    max() {
        if (this.isEmpty()) {
            return null;
        } else {
            let runner = this.root;
            while (runner.right) {
                runner = runner.right;
            }
            return runner.value;
        }
    }

    contains(val) {
        if (this.isEmpty()) {
            return false;
        } else {
            let runner = this.root;
            while (runner) {
                if (val > runner.value) {
                    runner = runner.right;
                } else if (val < runner.value) {
                    runner = runner.left;
                } else if (runner.value == val) {
                    return true;
                }
            }
            return false;
        }
    }


    // BST Height
    // Write a function for your BST that returns how tall (the length of the longest running branch) your tree is

    // BST isBalanced
    // Write a function for your BST that returns true or false whether the tree is balanced, meaning the height of the left side of the tree is equal to or one branch height different from the right side

    findHeight(node = this.root) {
        if (node == null)
            return -1;
        else {
            var leftDepth = this.findHeight(node.left);
            var rightDepth = this.findHeight(node.right);

            if (leftDepth > rightDepth) {
                return (leftDepth + 1);
            } else {
                return (rightDepth + 1);
            }
        }
    }
    isBalanced(node = this.root) {
        if (!node) {
            return true;
        }

        if (Math.abs(this.height(node.left) - this.height(node.right)) > 1) {
            return false;
        }

        return this.isBalanced(node.left) && this.isBalanced(node.right);
    }

    isFull(node = this.root) {
        if (node == null) {
            return false;
        } else if (node.left == null && node.right == null) {
            return true;
        } else if (node.left != null && node.right != null) {
            return this.isFull(node.left) && this.isFull(node.right);
        } else {
            return false;
        }
    }
}

var newtree = new BST();

newtree.add(2);
newtree.add(1);
newtree.add(5);
// tree.add(4);
// tree.add(5);
// tree.add(6);
console.log(newtree.contains(2));
console.log(newtree.contains(5));
console.log(newtree.contains(8));
console.log(newtree.contains(1));
console.log(newtree.contains(7));
// console.log(newtree.size());
// console.log(newtree.height());
console.log(newtree.isFull());