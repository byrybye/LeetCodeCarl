pub(crate) fn main() {
    println!("Hello, world!");
    let v = vec![5];
    search(v, -5);
}

pub fn remove_element(nums: &mut Vec<i32>, val: i32) -> i32 {    
    let mut slow = 0;    
    for fast in 0..nums.len() {
        if nums[fast]!=val {
            nums[slow] = nums[fast];
            slow += 1;
        }
    }
    return slow as i32;
}

pub fn search(nums: Vec<i32>, target: i32) -> i32 {    
    if nums.len() < 1 {
        return -1;
    }    
    let mut left:i32 = 0;
    let mut right:i32 = (nums.len() - 1) as i32;
    while left <= right {
        let middle = (left + right) / 2;
        print!("{}",middle);
        if target < nums[middle as usize] {
            right = middle - 1;
        } else if target > nums[middle as usize] {
            left = middle + 1;
        } else {
            return middle;
        }
    }
    return -1;
}
