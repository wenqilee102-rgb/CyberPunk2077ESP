using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Frame : InteractiveDevice
	{
		private CBool _isLinkedToPower;
		private CString _smartFrameName;
		private CString _smartFrameDescriptionLocKey;
		private wCHandle<inkISystemRequestsHandler> _systemHandler;
		private CUInt32 _squatFactToken;
		private CUInt32 _questFactToken;
		private CUInt32 _powerFactToken;
		private CInt32 _activePhotoID;
		private CUInt32 _activePhotoHash;
		private RectF _activePhotoUV;
		private CHandle<inkGameNotificationToken> _frameSwitcherToken;

		[Ordinal(98)] 
		[RED("isLinkedToPower")] 
		public CBool IsLinkedToPower
		{
			get => GetProperty(ref _isLinkedToPower);
			set => SetProperty(ref _isLinkedToPower, value);
		}

		[Ordinal(99)] 
		[RED("smartFrameName")] 
		public CString SmartFrameName
		{
			get => GetProperty(ref _smartFrameName);
			set => SetProperty(ref _smartFrameName, value);
		}

		[Ordinal(100)] 
		[RED("smartFrameDescriptionLocKey")] 
		public CString SmartFrameDescriptionLocKey
		{
			get => GetProperty(ref _smartFrameDescriptionLocKey);
			set => SetProperty(ref _smartFrameDescriptionLocKey, value);
		}

		[Ordinal(101)] 
		[RED("systemHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetProperty(ref _systemHandler);
			set => SetProperty(ref _systemHandler, value);
		}

		[Ordinal(102)] 
		[RED("squatFactToken")] 
		public CUInt32 SquatFactToken
		{
			get => GetProperty(ref _squatFactToken);
			set => SetProperty(ref _squatFactToken, value);
		}

		[Ordinal(103)] 
		[RED("questFactToken")] 
		public CUInt32 QuestFactToken
		{
			get => GetProperty(ref _questFactToken);
			set => SetProperty(ref _questFactToken, value);
		}

		[Ordinal(104)] 
		[RED("powerFactToken")] 
		public CUInt32 PowerFactToken
		{
			get => GetProperty(ref _powerFactToken);
			set => SetProperty(ref _powerFactToken, value);
		}

		[Ordinal(105)] 
		[RED("activePhotoID")] 
		public CInt32 ActivePhotoID
		{
			get => GetProperty(ref _activePhotoID);
			set => SetProperty(ref _activePhotoID, value);
		}

		[Ordinal(106)] 
		[RED("activePhotoHash")] 
		public CUInt32 ActivePhotoHash
		{
			get => GetProperty(ref _activePhotoHash);
			set => SetProperty(ref _activePhotoHash, value);
		}

		[Ordinal(107)] 
		[RED("activePhotoUV")] 
		public RectF ActivePhotoUV
		{
			get => GetProperty(ref _activePhotoUV);
			set => SetProperty(ref _activePhotoUV, value);
		}

		[Ordinal(108)] 
		[RED("frameSwitcherToken")] 
		public CHandle<inkGameNotificationToken> FrameSwitcherToken
		{
			get => GetProperty(ref _frameSwitcherToken);
			set => SetProperty(ref _frameSwitcherToken, value);
		}

		public Frame(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
