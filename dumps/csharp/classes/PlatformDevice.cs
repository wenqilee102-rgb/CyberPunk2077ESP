using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlatformDevice : InteractiveDevice
	{
		private CHandle<gameMovingPlatform> _movingPlatform;
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnection;
		private CName _startAudioEvent;
		private CName _stopAudioEvent;
		private CName _movingVFX;

		[Ordinal(98)] 
		[RED("movingPlatform")] 
		public CHandle<gameMovingPlatform> MovingPlatform
		{
			get => GetProperty(ref _movingPlatform);
			set => SetProperty(ref _movingPlatform, value);
		}

		[Ordinal(99)] 
		[RED("offMeshConnection")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnection
		{
			get => GetProperty(ref _offMeshConnection);
			set => SetProperty(ref _offMeshConnection, value);
		}

		[Ordinal(100)] 
		[RED("StartAudioEvent")] 
		public CName StartAudioEvent
		{
			get => GetProperty(ref _startAudioEvent);
			set => SetProperty(ref _startAudioEvent, value);
		}

		[Ordinal(101)] 
		[RED("StopAudioEvent")] 
		public CName StopAudioEvent
		{
			get => GetProperty(ref _stopAudioEvent);
			set => SetProperty(ref _stopAudioEvent, value);
		}

		[Ordinal(102)] 
		[RED("MovingVFX")] 
		public CName MovingVFX
		{
			get => GetProperty(ref _movingVFX);
			set => SetProperty(ref _movingVFX, value);
		}

		public PlatformDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
