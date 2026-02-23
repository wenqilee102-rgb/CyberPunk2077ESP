using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckDeviceQuickhackData : CVariable
	{
		private wCHandle<gamedataUIIcon_Record> _uIIcon;
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CName _objectActionName;
		private CName _objectActionLocName;
		private CEnum<gamedataDeviceHackTier> _objectActionTier;
		private CEnum<gamedataDeviceHackCategory> _objectActionCategory;
		private CEnum<gamedataObjectActionType> _objectActionType;
		private CFloat _priority;

		[Ordinal(0)] 
		[RED("UIIcon")] 
		public wCHandle<gamedataUIIcon_Record> UIIcon
		{
			get => GetProperty(ref _uIIcon);
			set => SetProperty(ref _uIIcon, value);
		}

		[Ordinal(1)] 
		[RED("ObjectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(2)] 
		[RED("ObjectActionName")] 
		public CName ObjectActionName
		{
			get => GetProperty(ref _objectActionName);
			set => SetProperty(ref _objectActionName, value);
		}

		[Ordinal(3)] 
		[RED("ObjectActionLocName")] 
		public CName ObjectActionLocName
		{
			get => GetProperty(ref _objectActionLocName);
			set => SetProperty(ref _objectActionLocName, value);
		}

		[Ordinal(4)] 
		[RED("ObjectActionTier")] 
		public CEnum<gamedataDeviceHackTier> ObjectActionTier
		{
			get => GetProperty(ref _objectActionTier);
			set => SetProperty(ref _objectActionTier, value);
		}

		[Ordinal(5)] 
		[RED("ObjectActionCategory")] 
		public CEnum<gamedataDeviceHackCategory> ObjectActionCategory
		{
			get => GetProperty(ref _objectActionCategory);
			set => SetProperty(ref _objectActionCategory, value);
		}

		[Ordinal(6)] 
		[RED("ObjectActionType")] 
		public CEnum<gamedataObjectActionType> ObjectActionType
		{
			get => GetProperty(ref _objectActionType);
			set => SetProperty(ref _objectActionType, value);
		}

		[Ordinal(7)] 
		[RED("Priority")] 
		public CFloat Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		public CyberdeckDeviceQuickhackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
