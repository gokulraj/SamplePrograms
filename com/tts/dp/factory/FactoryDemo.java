//$Id$
package com.tts.dp.factory;

public class FactoryDemo {

	public static void main(String[] args){
		ModuleFactory mf = new ModuleFactory();
		Module m = mf.getModule("Leads");
		m.creat();
		
		m = mf.getModule("Contacts");
		m.update();
		
		m = mf.getModule("Tasks");
		m.delete();
		
	}
}
