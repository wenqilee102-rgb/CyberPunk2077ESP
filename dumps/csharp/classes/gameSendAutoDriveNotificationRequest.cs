using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSendAutoDriveNotificationRequest : gameScriptableSystemRequest
	{
		private CString _locKey;
		private CBool _isDelamain;

		[Ordinal(0)] 
		[RED("locKey")] 
		public CString LocKey
		{
			get => GetProperty(ref _locKey);
			set => SetProperty(ref _locKey, value);
		}

		[Ordinal(1)] 
		[RED("isDelamain")] 
		public CBool IsDelamain
		{
			get => GetProperty(ref _isDelamain);
			set => SetProperty(ref _isDelamain, value);
		}

		public gameSendAutoDriveNotificationRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
