use std::{cell::RefCell, rc::Rc, ops::Deref};

struct ListNode {
    next: Option<Box<ListNode>>,
    val: i32,
}
struct MyLinkedList {
    dummy_head: Option<Box<ListNode>>,
    count: i32,
}

impl MyLinkedList {
    fn new() -> Self {
        MyLinkedList {
            dummy_head: Some(Box::new(ListNode { next: None, val: -1 })),
            count: 0,
        }
    }

    fn get(&self, index: i32) -> i32 {
        1
    }

    fn add_at_head(&self, val: i32) {
        let head = self.dummy_head.as_ref().unwrap().next.as_ref().unwrap();
        //let newNode = Some(Box::new(ListNode{next: Some(head), val:val }));
    }

    fn add_at_tail(&self, val: i32) {}

    fn add_at_index(&self, index: i32, val: i32) {}

    fn delete_at_index(&self, index: i32) {}

    fn print(&self) {
        let mut current = self.dummy_head.as_ref().unwrap();
        while current.next.is_some() {
            current = current.next.as_ref().unwrap();
            println!("{}", current.val);            
        }
        println!("{}",current.val);
    }
}
