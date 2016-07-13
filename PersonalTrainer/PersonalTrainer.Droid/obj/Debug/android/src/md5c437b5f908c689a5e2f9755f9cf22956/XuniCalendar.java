package md5c437b5f908c689a5e2f9755f9cf22956;


public class XuniCalendar
	extends com.grapecity.xuni.calendar.XuniCalendar
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDaySlotLoading:(Lcom/grapecity/xuni/calendar/CalendarDaySlotLoadingEventArgs;)V:GetOnDaySlotLoading_Lcom_grapecity_xuni_calendar_CalendarDaySlotLoadingEventArgs_Handler\n" +
			"n_onDisplayModeChanged:(Lcom/grapecity/xuni/core/EventArgs;)V:GetOnDisplayModeChanged_Lcom_grapecity_xuni_core_EventArgs_Handler\n" +
			"n_onDisplayDateChanged:(Lcom/grapecity/xuni/core/EventArgs;)V:GetOnDisplayDateChanged_Lcom_grapecity_xuni_core_EventArgs_Handler\n" +
			"n_onDisplayDateChanging:(Lcom/grapecity/xuni/core/EventArgs;)V:GetOnDisplayDateChanging_Lcom_grapecity_xuni_core_EventArgs_Handler\n" +
			"n_onMonthSlotLoading:(Lcom/grapecity/xuni/calendar/CalendarMonthSlotLoadingEventArgs;)V:GetOnMonthSlotLoading_Lcom_grapecity_xuni_calendar_CalendarMonthSlotLoadingEventArgs_Handler\n" +
			"n_onDayOfWeekSlotLoading:(Lcom/grapecity/xuni/calendar/CalendarDayOfWeekSlotLoadingEventArgs;)V:GetOnDayOfWeekSlotLoading_Lcom_grapecity_xuni_calendar_CalendarDayOfWeekSlotLoadingEventArgs_Handler\n" +
			"n_onSelectionChanging:(Lcom/grapecity/xuni/calendar/CalendarSelectionChangingEventArgs;)V:GetOnSelectionChanging_Lcom_grapecity_xuni_calendar_CalendarSelectionChangingEventArgs_Handler\n" +
			"n_onSelectionChanged:(Lcom/grapecity/xuni/calendar/CalendarSelectionChangedEventArgs;)V:GetOnSelectionChanged_Lcom_grapecity_xuni_calendar_CalendarSelectionChangedEventArgs_Handler\n" +
			"";
		mono.android.Runtime.register ("Com.GrapeCity.Xuni.Calendar.XuniCalendar, Xuni.Android.Calendar, Version=2.2.20161.102, Culture=neutral, PublicKeyToken=null", XuniCalendar.class, __md_methods);
	}


	public XuniCalendar (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == XuniCalendar.class)
			mono.android.TypeManager.Activate ("Com.GrapeCity.Xuni.Calendar.XuniCalendar, Xuni.Android.Calendar, Version=2.2.20161.102, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public XuniCalendar (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == XuniCalendar.class)
			mono.android.TypeManager.Activate ("Com.GrapeCity.Xuni.Calendar.XuniCalendar, Xuni.Android.Calendar, Version=2.2.20161.102, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onDaySlotLoading (com.grapecity.xuni.calendar.CalendarDaySlotLoadingEventArgs p0)
	{
		n_onDaySlotLoading (p0);
	}

	private native void n_onDaySlotLoading (com.grapecity.xuni.calendar.CalendarDaySlotLoadingEventArgs p0);


	public void onDisplayModeChanged (com.grapecity.xuni.core.EventArgs p0)
	{
		n_onDisplayModeChanged (p0);
	}

	private native void n_onDisplayModeChanged (com.grapecity.xuni.core.EventArgs p0);


	public void onDisplayDateChanged (com.grapecity.xuni.core.EventArgs p0)
	{
		n_onDisplayDateChanged (p0);
	}

	private native void n_onDisplayDateChanged (com.grapecity.xuni.core.EventArgs p0);


	public void onDisplayDateChanging (com.grapecity.xuni.core.EventArgs p0)
	{
		n_onDisplayDateChanging (p0);
	}

	private native void n_onDisplayDateChanging (com.grapecity.xuni.core.EventArgs p0);


	public void onMonthSlotLoading (com.grapecity.xuni.calendar.CalendarMonthSlotLoadingEventArgs p0)
	{
		n_onMonthSlotLoading (p0);
	}

	private native void n_onMonthSlotLoading (com.grapecity.xuni.calendar.CalendarMonthSlotLoadingEventArgs p0);


	public void onDayOfWeekSlotLoading (com.grapecity.xuni.calendar.CalendarDayOfWeekSlotLoadingEventArgs p0)
	{
		n_onDayOfWeekSlotLoading (p0);
	}

	private native void n_onDayOfWeekSlotLoading (com.grapecity.xuni.calendar.CalendarDayOfWeekSlotLoadingEventArgs p0);


	public void onSelectionChanging (com.grapecity.xuni.calendar.CalendarSelectionChangingEventArgs p0)
	{
		n_onSelectionChanging (p0);
	}

	private native void n_onSelectionChanging (com.grapecity.xuni.calendar.CalendarSelectionChangingEventArgs p0);


	public void onSelectionChanged (com.grapecity.xuni.calendar.CalendarSelectionChangedEventArgs p0)
	{
		n_onSelectionChanged (p0);
	}

	private native void n_onSelectionChanged (com.grapecity.xuni.calendar.CalendarSelectionChangedEventArgs p0);

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
