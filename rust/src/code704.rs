
pub fn add(a: i32, b: i32) -> i32 {
    a + b
}

pub fn search(nums: Vec<i32>, target: i32) -> i32 {
    if nums.len() < 1 {
        return -1;
    }
    let mut left: i32 = 0;
    let mut right: i32 = (nums.len() - 1) as i32;
    while left <= right {
        let middle = (left + right) / 2;
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
