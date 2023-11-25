fn is_palindrome(x: i32) -> bool {
   let number_string = x.to_string();
   let reversed_string: String = number_string.chars().rev().collect();
   number_string == reversed_string
}

fn main() {
   println!("\n\n\n{}", is_palindrome(121));
   println!("{}", is_palindrome(212));
   println!("{}", is_palindrome(98));
}
 