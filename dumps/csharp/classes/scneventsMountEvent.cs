using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsMountEvent : scnSceneEvent
	{
		private scnPerformerId _parent;
		private scnPerformerId _child;
		private CName _slotName;
		private CEnum<gamePSMBodyCarryingStyle> _carryStyle;
		private CBool _isInstant;
		private CBool _removePitchRollRotationOnDismount;
		private CBool _keepTransform;
		private CBool _isCarrying;
		private CBool _switchRenderPlane;

		[Ordinal(6)] 
		[RED("parent")] 
		public scnPerformerId Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(7)] 
		[RED("child")] 
		public scnPerformerId Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(9)] 
		[RED("carryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> CarryStyle
		{
			get => GetProperty(ref _carryStyle);
			set => SetProperty(ref _carryStyle, value);
		}

		[Ordinal(10)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(11)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetProperty(ref _removePitchRollRotationOnDismount);
			set => SetProperty(ref _removePitchRollRotationOnDismount, value);
		}

		[Ordinal(12)] 
		[RED("keepTransform")] 
		public CBool KeepTransform
		{
			get => GetProperty(ref _keepTransform);
			set => SetProperty(ref _keepTransform, value);
		}

		[Ordinal(13)] 
		[RED("isCarrying")] 
		public CBool IsCarrying
		{
			get => GetProperty(ref _isCarrying);
			set => SetProperty(ref _isCarrying, value);
		}

		[Ordinal(14)] 
		[RED("switchRenderPlane")] 
		public CBool SwitchRenderPlane
		{
			get => GetProperty(ref _switchRenderPlane);
			set => SetProperty(ref _switchRenderPlane, value);
		}

		public scneventsMountEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
