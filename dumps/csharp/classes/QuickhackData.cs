using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackData : IScriptable
	{
		private entEntityID _actionOwner;
		private CHandle<BaseScriptableAction> _action;
		private CName _actionOwnerName;
		private gameItemID _itemID;
		private TweakDBID _icon;
		private CName _iconCategory;
		private CString _title;
		private CString _titleAlternative;
		private CString _description;
		private CString _inactiveReason;
		private CBool _isLocked;
		private CEnum<EActionInactivityReson> _actionState;
		private CEnum<gamedataObjectActionType> _type;
		private CInt32 _cost;
		private CFloat _awarenessCost;
		private CBool _showRevealInfo;
		private CBool _willReveal;
		private CInt32 _costRaw;
		private CFloat _uploadTime;
		private CFloat _duration;
		private CBool _iCELevelVisible;
		private CFloat _iCELevel;
		private CArray<TweakDBID> _vulnerabilities;
		private CInt32 _quality;
		private CBool _isInstant;
		private CFloat _cooldown;
		private TweakDBID _cooldownTweak;
		private CBool _actionMatchesTarget;
		private CInt32 _maxListSize;
		private wCHandle<gamedataHackCategory_Record> _category;
		private CArray<wCHandle<gamedataObjectActionEffect_Record>> _actionCompletionEffects;
		private CBool _noQuickhackData;
		private CBool _networkBreached;

		[Ordinal(0)] 
		[RED("actionOwner")] 
		public entEntityID ActionOwner
		{
			get => GetProperty(ref _actionOwner);
			set => SetProperty(ref _actionOwner, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(2)] 
		[RED("actionOwnerName")] 
		public CName ActionOwnerName
		{
			get => GetProperty(ref _actionOwnerName);
			set => SetProperty(ref _actionOwnerName, value);
		}

		[Ordinal(3)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(4)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(5)] 
		[RED("iconCategory")] 
		public CName IconCategory
		{
			get => GetProperty(ref _iconCategory);
			set => SetProperty(ref _iconCategory, value);
		}

		[Ordinal(6)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(7)] 
		[RED("titleAlternative")] 
		public CString TitleAlternative
		{
			get => GetProperty(ref _titleAlternative);
			set => SetProperty(ref _titleAlternative, value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(9)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetProperty(ref _inactiveReason);
			set => SetProperty(ref _inactiveReason, value);
		}

		[Ordinal(10)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(11)] 
		[RED("actionState")] 
		public CEnum<EActionInactivityReson> ActionState
		{
			get => GetProperty(ref _actionState);
			set => SetProperty(ref _actionState, value);
		}

		[Ordinal(12)] 
		[RED("type")] 
		public CEnum<gamedataObjectActionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(13)] 
		[RED("cost")] 
		public CInt32 Cost
		{
			get => GetProperty(ref _cost);
			set => SetProperty(ref _cost, value);
		}

		[Ordinal(14)] 
		[RED("awarenessCost")] 
		public CFloat AwarenessCost
		{
			get => GetProperty(ref _awarenessCost);
			set => SetProperty(ref _awarenessCost, value);
		}

		[Ordinal(15)] 
		[RED("showRevealInfo")] 
		public CBool ShowRevealInfo
		{
			get => GetProperty(ref _showRevealInfo);
			set => SetProperty(ref _showRevealInfo, value);
		}

		[Ordinal(16)] 
		[RED("willReveal")] 
		public CBool WillReveal
		{
			get => GetProperty(ref _willReveal);
			set => SetProperty(ref _willReveal, value);
		}

		[Ordinal(17)] 
		[RED("costRaw")] 
		public CInt32 CostRaw
		{
			get => GetProperty(ref _costRaw);
			set => SetProperty(ref _costRaw, value);
		}

		[Ordinal(18)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetProperty(ref _uploadTime);
			set => SetProperty(ref _uploadTime, value);
		}

		[Ordinal(19)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(20)] 
		[RED("ICELevelVisible")] 
		public CBool ICELevelVisible
		{
			get => GetProperty(ref _iCELevelVisible);
			set => SetProperty(ref _iCELevelVisible, value);
		}

		[Ordinal(21)] 
		[RED("ICELevel")] 
		public CFloat ICELevel
		{
			get => GetProperty(ref _iCELevel);
			set => SetProperty(ref _iCELevel, value);
		}

		[Ordinal(22)] 
		[RED("vulnerabilities")] 
		public CArray<TweakDBID> Vulnerabilities
		{
			get => GetProperty(ref _vulnerabilities);
			set => SetProperty(ref _vulnerabilities, value);
		}

		[Ordinal(23)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(24)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(25)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(26)] 
		[RED("cooldownTweak")] 
		public TweakDBID CooldownTweak
		{
			get => GetProperty(ref _cooldownTweak);
			set => SetProperty(ref _cooldownTweak, value);
		}

		[Ordinal(27)] 
		[RED("actionMatchesTarget")] 
		public CBool ActionMatchesTarget
		{
			get => GetProperty(ref _actionMatchesTarget);
			set => SetProperty(ref _actionMatchesTarget, value);
		}

		[Ordinal(28)] 
		[RED("maxListSize")] 
		public CInt32 MaxListSize
		{
			get => GetProperty(ref _maxListSize);
			set => SetProperty(ref _maxListSize, value);
		}

		[Ordinal(29)] 
		[RED("category")] 
		public wCHandle<gamedataHackCategory_Record> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(30)] 
		[RED("actionCompletionEffects")] 
		public CArray<wCHandle<gamedataObjectActionEffect_Record>> ActionCompletionEffects
		{
			get => GetProperty(ref _actionCompletionEffects);
			set => SetProperty(ref _actionCompletionEffects, value);
		}

		[Ordinal(31)] 
		[RED("noQuickhackData")] 
		public CBool NoQuickhackData
		{
			get => GetProperty(ref _noQuickhackData);
			set => SetProperty(ref _noQuickhackData, value);
		}

		[Ordinal(32)] 
		[RED("networkBreached")] 
		public CBool NetworkBreached
		{
			get => GetProperty(ref _networkBreached);
			set => SetProperty(ref _networkBreached, value);
		}

		public QuickhackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
