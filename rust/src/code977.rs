pub fn sorted_squares(nums: Vec<i32>) -> Vec<i32> {
    let mut left = 0;
    let len = nums.len();
    let mut right = len - 1;
    let mut postion = len - 1;
    let mut result: Vec<i32> = vec![0; len];
    while left <= right {
        if nums[left] * nums[left] > nums[right] * nums[right] {
            result[postion] = nums[left] * nums[left];
            left += 1;
        } else {
            result[postion] = nums[right] * nums[right];
            if right > 0 {
                right -= 1;
            }
        }
        if postion > 0 {
            postion -= 1;
        } else {
            break;
        }
    }
    result
}