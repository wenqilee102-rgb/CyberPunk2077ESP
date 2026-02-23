using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiLocalPhoneElement : gameuiPhoneElementVisibility
	{
		private CName _libraryID;
		private wCHandle<inkAsyncSpawnRequest> _request;
		private wCHandle<inkWidget> _widget;

		[Ordinal(3)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetProperty(ref _libraryID);
			set => SetProperty(ref _libraryID, value);
		}

		[Ordinal(4)] 
		[RED("request")] 
		public wCHandle<inkAsyncSpawnRequest> Request
		{
			get => GetProperty(ref _request);
			set => SetProperty(ref _request, value);
		}

		[Ordinal(5)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public gameuiLocalPhoneElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
