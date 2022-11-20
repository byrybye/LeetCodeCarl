pub fn min_sub_array_len(target: i32, nums: Vec<i32>) -> i32 {
    let mut start = 0;    
    let mut  sum = 0;
    let mut  sub_len = 0;
    let mut  result: i32 = i32::MAX;
    for (end, value) in nums.iter().enumerate()
    {
        sum += value;
        while sum >= target {
            sub_len = end - start + 1;
            result = i32::min(result, sub_len as i32);
            sum -= nums[start as usize];
            start += 1;
        }
    }
    if result == i32::MAX{ return 0;}
    result
}
