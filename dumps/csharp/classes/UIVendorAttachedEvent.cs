using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIVendorAttachedEvent : redEvent
	{
		private TweakDBID _vendorID;
		private wCHandle<gameObject> _vendorObject;

		[Ordinal(0)] 
		[RED("vendorID")] 
		public TweakDBID VendorID
		{
			get => GetProperty(ref _vendorID);
			set => SetProperty(ref _vendorID, value);
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public wCHandle<gameObject> VendorObject
		{
			get => GetProperty(ref _vendorObject);
			set => SetProperty(ref _vendorObject, value);
		}

		public UIVendorAttachedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
