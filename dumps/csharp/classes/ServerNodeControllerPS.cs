using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerNodeControllerPS : ScriptableDeviceComponentPS
	{
		private CEnum<CoverState> _coverState;
		private CEnum<ServerState> _serverState;
		private CArrayFixedSize<CInt32> _destroyedPin;

		[Ordinal(107)] 
		[RED("coverState")] 
		public CEnum<CoverState> CoverState
		{
			get => GetProperty(ref _coverState);
			set => SetProperty(ref _coverState, value);
		}

		[Ordinal(108)] 
		[RED("serverState")] 
		public CEnum<ServerState> ServerState
		{
			get => GetProperty(ref _serverState);
			set => SetProperty(ref _serverState, value);
		}

		[Ordinal(109)] 
		[RED("destroyedPin", 12)] 
		public CArrayFixedSize<CInt32> DestroyedPin
		{
			get => GetProperty(ref _destroyedPin);
			set => SetProperty(ref _destroyedPin, value);
		}

		public ServerNodeControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
