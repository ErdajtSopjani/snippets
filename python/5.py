def is_palindrome(x):
   number_string = str(x)
   reversed_string = number_string[::-1]
   return number_string == reversed_string

print("\n\n\n" + str(is_palindrome(121)))
print(is_palindrome(212))
print(is_palindrome(98) + "\n\n\n")
