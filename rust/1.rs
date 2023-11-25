fn str_str(haystack: &str, needle: &str) -> i32 {
   for i in 0..=haystack.len() - needle.len() {
       if &haystack[i..i+needle.len()] == needle {
           return i as i32;
       }
   }
   return -1;
}

fn main() {
   let haystack = ["bassadbas", "sleetcodes", "github"];
   let needle = ["sad", "leetcode", "ggithub"];

   println!("{}", str_str(haystack[0], needle[0]));
   println!("{}", str_str(haystack[1], needle[1]));
   println!("{}", str_str(haystack[2], needle[2]));
}