using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmasherPlayVFX : AIbehaviortaskScript
	{
		private Vector3 _vfxOffset;
		private gameFxResource _vfxResource;
		private CHandle<AIArgumentMapping> _fxDirection;
		private CName _attachmentSlotName;
		private CFloat _delay;
		private CBool _killFx;
		private CName _effectToKill;
		private wCHandle<gameObject> _owner;
		private CHandle<gameFxInstance> _vfxInstance;
		private CFloat _startTime;

		[Ordinal(0)] 
		[RED("vfxOffset")] 
		public Vector3 VfxOffset
		{
			get => GetProperty(ref _vfxOffset);
			set => SetProperty(ref _vfxOffset, value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetProperty(ref _vfxResource);
			set => SetProperty(ref _vfxResource, value);
		}

		[Ordinal(2)] 
		[RED("fxDirection")] 
		public CHandle<AIArgumentMapping> FxDirection
		{
			get => GetProperty(ref _fxDirection);
			set => SetProperty(ref _fxDirection, value);
		}

		[Ordinal(3)] 
		[RED("attachmentSlotName")] 
		public CName AttachmentSlotName
		{
			get => GetProperty(ref _attachmentSlotName);
			set => SetProperty(ref _attachmentSlotName, value);
		}

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(5)] 
		[RED("KillFx")] 
		public CBool KillFx
		{
			get => GetProperty(ref _killFx);
			set => SetProperty(ref _killFx, value);
		}

		[Ordinal(6)] 
		[RED("effectToKill")] 
		public CName EffectToKill
		{
			get => GetProperty(ref _effectToKill);
			set => SetProperty(ref _effectToKill, value);
		}

		[Ordinal(7)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(8)] 
		[RED("vfxInstance")] 
		public CHandle<gameFxInstance> VfxInstance
		{
			get => GetProperty(ref _vfxInstance);
			set => SetProperty(ref _vfxInstance, value);
		}

		[Ordinal(9)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		public SmasherPlayVFX(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
