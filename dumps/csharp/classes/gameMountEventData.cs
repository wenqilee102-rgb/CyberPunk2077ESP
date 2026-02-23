using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountEventData : IScriptable
	{
		private CName _slotName;
		private entEntityID _mountParentEntityId;
		private CBool _isInstant;
		private CName _entryAnimName;
		private CName _entrySlotName;
		private Transform _initialTransformLS;
		private CBool _setEntityVisibleWhenMountFinish;
		private CBool _removePitchRollRotationOnDismount;
		private CBool _ignoreHLS;
		private CBool _switchRenderPlane;
		private CBool _isJustAttached;
		private CBool _isCarrying;
		private CBool _allowFailsafeTeleport;
		private CHandle<gameMountEventOptions> _mountEventOptions;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("mountParentEntityId")] 
		public entEntityID MountParentEntityId
		{
			get => GetProperty(ref _mountParentEntityId);
			set => SetProperty(ref _mountParentEntityId, value);
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(3)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get => GetProperty(ref _entryAnimName);
			set => SetProperty(ref _entryAnimName, value);
		}

		[Ordinal(4)] 
		[RED("entrySlotName")] 
		public CName EntrySlotName
		{
			get => GetProperty(ref _entrySlotName);
			set => SetProperty(ref _entrySlotName, value);
		}

		[Ordinal(5)] 
		[RED("initialTransformLS")] 
		public Transform InitialTransformLS
		{
			get => GetProperty(ref _initialTransformLS);
			set => SetProperty(ref _initialTransformLS, value);
		}

		[Ordinal(6)] 
		[RED("setEntityVisibleWhenMountFinish")] 
		public CBool SetEntityVisibleWhenMountFinish
		{
			get => GetProperty(ref _setEntityVisibleWhenMountFinish);
			set => SetProperty(ref _setEntityVisibleWhenMountFinish, value);
		}

		[Ordinal(7)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetProperty(ref _removePitchRollRotationOnDismount);
			set => SetProperty(ref _removePitchRollRotationOnDismount, value);
		}

		[Ordinal(8)] 
		[RED("ignoreHLS")] 
		public CBool IgnoreHLS
		{
			get => GetProperty(ref _ignoreHLS);
			set => SetProperty(ref _ignoreHLS, value);
		}

		[Ordinal(9)] 
		[RED("switchRenderPlane")] 
		public CBool SwitchRenderPlane
		{
			get => GetProperty(ref _switchRenderPlane);
			set => SetProperty(ref _switchRenderPlane, value);
		}

		[Ordinal(10)] 
		[RED("isJustAttached")] 
		public CBool IsJustAttached
		{
			get => GetProperty(ref _isJustAttached);
			set => SetProperty(ref _isJustAttached, value);
		}

		[Ordinal(11)] 
		[RED("isCarrying")] 
		public CBool IsCarrying
		{
			get => GetProperty(ref _isCarrying);
			set => SetProperty(ref _isCarrying, value);
		}

		[Ordinal(12)] 
		[RED("allowFailsafeTeleport")] 
		public CBool AllowFailsafeTeleport
		{
			get => GetProperty(ref _allowFailsafeTeleport);
			set => SetProperty(ref _allowFailsafeTeleport, value);
		}

		[Ordinal(13)] 
		[RED("mountEventOptions")] 
		public CHandle<gameMountEventOptions> MountEventOptions
		{
			get => GetProperty(ref _mountEventOptions);
			set => SetProperty(ref _mountEventOptions, value);
		}

		public gameMountEventData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
