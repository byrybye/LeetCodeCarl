pub fn remove_element(nums: &mut Vec<i32>, val: i32) -> i32 {
    let mut slow = 0;
    for fast in 0..nums.len() {
        if nums[fast] != val {
            nums[slow] = nums[fast];
            slow += 1;
        }
    }
    return slow as i32;
}