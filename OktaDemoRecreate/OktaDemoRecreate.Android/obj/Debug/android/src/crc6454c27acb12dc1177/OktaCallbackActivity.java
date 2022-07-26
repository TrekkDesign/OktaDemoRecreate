package crc6454c27acb12dc1177;


public class OktaCallbackActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("OktaDemoRecreate.Droid.OktaCallbackActivity, OktaDemoRecreate.Android", OktaCallbackActivity.class, __md_methods);
	}


	public OktaCallbackActivity ()
	{
		super ();
		if (getClass () == OktaCallbackActivity.class)
			mono.android.TypeManager.Activate ("OktaDemoRecreate.Droid.OktaCallbackActivity, OktaDemoRecreate.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
