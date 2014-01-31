//$Id$
package com.tts.dp.factory;

public class Leads implements Module {

	@Override
	public long creat() {
		// TODO Auto-generated method stub
		System.out.println("Lead Created");
		return 0;
	}

	@Override
	public long update() {
		// TODO Auto-generated method stub
		System.out.println("Lead Updated");
		return 0;
	}

	@Override
	public long delete() {
		// TODO Auto-generated method stub
		System.out.println("Lead Deleted");
		return 0;
	}

}
