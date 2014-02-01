//$Id$
package com.tts.dp.factory;

public class Tasks implements Module {

	@Override
	public long creat() {
		// TODO Auto-generated method stub
		System.out.println("Task Created");
		return 0;
	}

	@Override
	public long update() {
		// TODO Auto-generated method stub
		System.out.println("Task Updated");
		return 0;
	}

	@Override
	public long delete() {
		// TODO Auto-generated method stub
		System.out.println("Task Deleted");
		return 0;
	}
}
