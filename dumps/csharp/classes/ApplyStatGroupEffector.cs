using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatGroupEffector : gameEffector
	{
		private gameStatsObjectID _target;
		private TweakDBID _record;
		private CName _applicationTarget;
		private CUInt64 _modGroupID;
		private CUInt8 _stackCount;
		private CBool _removeWithEffector;
		private CBool _reapplyOnWeaponChange;
		private wCHandle<gameObject> _owner;
		private CHandle<ApplyStatGroupEffectorCallback> _ownerSlotCallback;
		private CHandle<gameAttachmentSlotsScriptListener> _ownerSlotListener;

		[Ordinal(0)] 
		[RED("target")] 
		public gameStatsObjectID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(2)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(3)] 
		[RED("modGroupID")] 
		public CUInt64 ModGroupID
		{
			get => GetProperty(ref _modGroupID);
			set => SetProperty(ref _modGroupID, value);
		}

		[Ordinal(4)] 
		[RED("stackCount")] 
		public CUInt8 StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}

		[Ordinal(5)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get => GetProperty(ref _removeWithEffector);
			set => SetProperty(ref _removeWithEffector, value);
		}

		[Ordinal(6)] 
		[RED("reapplyOnWeaponChange")] 
		public CBool ReapplyOnWeaponChange
		{
			get => GetProperty(ref _reapplyOnWeaponChange);
			set => SetProperty(ref _reapplyOnWeaponChange, value);
		}

		[Ordinal(7)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(8)] 
		[RED("ownerSlotCallback")] 
		public CHandle<ApplyStatGroupEffectorCallback> OwnerSlotCallback
		{
			get => GetProperty(ref _ownerSlotCallback);
			set => SetProperty(ref _ownerSlotCallback, value);
		}

		[Ordinal(9)] 
		[RED("ownerSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> OwnerSlotListener
		{
			get => GetProperty(ref _ownerSlotListener);
			set => SetProperty(ref _ownerSlotListener, value);
		}

		public ApplyStatGroupEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
