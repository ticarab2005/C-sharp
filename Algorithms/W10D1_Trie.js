// Tries

// Trie Node
class TrieNode {
    constructor(val) {
        // This value is a single letter
        this.val = val;
        this.isWord = false;
        // children
        this.children = new Array(26).fill(null);
        // [null, null, null, null, null, null, null, null,...]
        //   0    1      2     3     4     5     6     7 
    }
}

class Trie {
    constructor() {
            this.root = new TrieNode("");
        }
        // Add a word to our trie
    add(word) {
            // Start at our root
            let runner = this.root;
            // safety check, make sure all my letters are lowercase
            word = word.toLowerCase();
            // I need to go through my letters and find or add each of them in individually
            // Step one: loop through my word
            for (let letter = 0; letter < word.length; letter++) {
                // My children are built on an array that is structured to keep all my letters in alphabetical order
                // So, for example, "c" would be located at index 2
                // So if I look at children[2] I would expect to see either TrieNode(c) OR null
                // First: identify where the letter SHOULD be
                let index = word[letter].charCodeAt(0) - 97;
                // console.log(index);
                // Second: find out if anything is at that location
                if (runner.children[index] == null) {
                    // If it is equal to null, nothing is there, which means I need to add the value in
                    console.log(`The letter ${word[letter]} was not present. Adding new trieNode now`);
                    runner.children[index] = new TrieNode(word[letter]);
                }
                // Third: I want to move down to that letter in the child array
                runner = runner.children[index];
            }
            runner.isWord = true;
            console.log(`${word} was added successfully`);
        }
        // Trie Contains
        // Given a string, return true or false whether that string exists in the trie

    contain(word) {
        if (word.length < 1) {
            return false;
        }
        let runner = this.root;
        word = word.toLowerCase();
        for (let i = 0; i < word.length; i++) {
            let index = word[i].charCodeAt(0) - 97;
            if (runner.children[index]) {
                runner = runner.children[index];
            } else {
                return false;
            }
        }
        if (runner.isWord == true) {
            return true;
        } else {
            return false;
        }
    }


    // Autocomplete
    // Alright we've come to the final challenge with tries! The autocomplete! We can add words and confirm what words are in our trie, now write a function that, given a starter bit of letters, returns all words down that particular branch
    // Ex, say we have a trie that has the words "car", "cat", "dog", carrot", "saw", and "can"
    // if we ran autocomplete("ca"), we would expect back an array with ["car", "cat", "carrot", "can"]
    // if we ran autocomplete("car") we would expect back an array with ["car","carrot"] - NOT cat and can, because they don't start with "car"
    // Hint: you might have the best luck with this one using our old friend recursion

    // Need to find all words in a trie based on starter input
    // Start by creating an array to hold our answers
    // Then create a runner to go down the branches
    // Our rnner needs to go down to the last letter in the starter
    // Use a loop that goes through stater string length
    // Look to see if there is a valid child to go to 
    // Move runner doewn to that child
    // Once we're at the end of our starter, we need to search for any valid children
    // If child != null, go down to it 
    // Add the letter of child to string
    // Now look for it's valid children
    // Repeat the last 3 steps 

    // autocomplete(start) {
    //     arr = [];
    //     runner = this.root;
    //     start = start.toLowerCase();
    //     string = "";
    //     for (var i = 0; i < start.length; i++) {
    //         let index = start[i].charCodeAt(0) - 97;
    //         if (runner.children[index] == null) {
    //             return null;
    //         } else {
    //             runner = runner.children[index];
    //             string += runner.val;
    //         }
    //     }
    //     return arrayOfWords;
    // }
    autocomplete(start) {
        if (start.length < 1) {
            return "Pass an argument";
        }
        let runner = this.root;
        start = start.toLowerCase();
        for (let i = 0; i < start.length; i++) {
            let index = start[i].charCodeAt(0) - 97;
            if (runner.children[index] == null) {
                return [];
            }
            runner = runner.children[index];
        }
        let arrayOfWords = [];
        this.collect(runner, arrayOfWords, start)
        return arrayOfWords
    }

    helper(node, arrayOfWords, start) {
        if (node.isWord) {
            arrayOfWords.push(start);
        }
        for (var i = 0; i < start.length; i++) {
            if (node.children[i] != null) {
                this.helper(node.children[i], arrayOfWords, start + node.children[i].val);
            }
        }
    }

}


// Autocomplete
// Alright we've come to the final challenge with tries! The autocomplete! We can add words and confirm what words are in our trie, now write a function that, given a starter bit of letters, returns all words down that particular branch
// Ex, say we have a trie that has the words "car", "cat", "dog", carrot", "saw", and "can"
// if we ran autocomplete("ca"), we would expect back an array with ["car", "cat", "carrot", "can"]
// if we ran autocomplete("car") we would expect back an array with ["car","carrot"] - NOT cat and can, because they don't start with "car"
// Hint: you might have the best luck with this one using our old friend recursion


var myTrie = new Trie();
myTrie.add("CAR");
myTrie.add("CAT");
myTrie.add("APPLE");
myTrie.add("APE");
console.log(myTrie.contain("CAR"));
console.log(myTrie.contain("CAST"));
console.log(myTrie.contain("APPLE"));
console.log(myTrie.contain("APE"));
console.log(myTrie.contain("APEs"));
console.log(myTrie.contain("CA"));
// console.log(myTrie.autocomplete("CA"));