//$Id$
package com.tts.dp.factory;

public class Contacts implements Module {

	@Override
	public long creat() {
		// TODO Auto-generated method stub
		System.out.println("Contact Created");
		return 0;
	}

	@Override
	public long update() {
		// TODO Auto-generated method stub
		System.out.println("Contact Updated");
		return 0;
	}

	@Override
	public long delete() {
		// TODO Auto-generated method stub
		System.out.println("Contact Deleted");
		return 0;
	}

}
