function isPalindrome(x) {
  let numberString = x.toString();
  let reversedString = numberString.split('').reverse().join('');
  return numberString === reversedString;
}

console.log("\n\n\n" + isPalindrome(121));
console.log(isPalindrome(212));
console.log(isPalindrome(98) + "\n\n\n");
  