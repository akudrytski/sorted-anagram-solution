# Sorted anagram rank calculator (aka lexicographic rank calculator) 

## Intro
This is one of the test tasks I was asked to solve as a part of hiring process. Did it completely by myself(was a part of the task) not looking up information on the internet. It took me some time to come up to formula for permutations with repetitions which is n!/n1!n2!…*nk! where n = n1+n2+n3+…+nk and n1, n2, …,nk count of repetitions of a particular element. But once this formula has been obtained (later when I’ve got all the things working I checked that this one actually exists) I got completely working solution and proceeded to coding.

As a result I’ve got <500ms average execution time for “yxwvutsrqponmlkjihgfedcba” string rank calculation even for debug mode, that is basically the worst case. WOHOO!!! http://i.imgur.com/TojdunF.png

## Task Description
Given a string of letters (case insensitive), you can create the set of all words with those same letters (and the same frequency)

Example:

`"abab" => ["aabb", "abab", "abba", "baab", "baba", "bbaa"]`

If you sort this set of words, you can assign a rank to the input word based on where it is in the sorted list.

`abab = 2`


Write a function that takes in a string and returns it's rank. Your function must accept any word 25 characters or less (repeated characters OK), and must complete in < 500ms.

Examples

```
aaab = 1
abab = 2
baaa = 4
coolword = 406
beekeeper = 63
zoologist = 57649
```

### Solution
(Try clicking the image and pressing "Raw" if pictures are not shown in portrait orientation, this is the github issue.)
![First page](/documentation/SolutionFirstPage.JPG)
![Second page](/documentation/SolutionSecondPage.JPG)
Ink spent to come up to the solution:
![Captured process](/documentation/ProcessCaptured.JPG)
