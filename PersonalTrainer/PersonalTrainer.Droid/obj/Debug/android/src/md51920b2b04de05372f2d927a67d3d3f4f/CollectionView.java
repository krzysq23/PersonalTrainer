package md51920b2b04de05372f2d927a67d3d3f4f;


public class CollectionView
	extends com.grapecity.xuni.core.CollectionView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.GrapeCity.Xuni.Core.CollectionView, Xuni.Android.Core, Version=2.2.20161.102, Culture=neutral, PublicKeyToken=null", CollectionView.class, __md_methods);
	}


	public CollectionView (java.util.List p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == CollectionView.class)
			mono.android.TypeManager.Activate ("Com.GrapeCity.Xuni.Core.CollectionView, Xuni.Android.Core, Version=2.2.20161.102, Culture=neutral, PublicKeyToken=null", "System.Collections.IList, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
	}

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
