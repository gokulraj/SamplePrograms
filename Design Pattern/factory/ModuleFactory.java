//$Id$
package com.tts.dp.factory;

import javax.xml.crypto.dsig.keyinfo.RetrievalMethod;

public class ModuleFactory {

	public Module getModule(String n){
		
		if(n == null ){
			return null;
		}
		if (n.equals("Leads")){
			return new Leads();
		}
		else if ( n.equals("Contacts") ) {
			return new Contacts();
		}
		else if (n.equals("Tasks")){
			return new Tasks();
		}
		return null;
	}
}
