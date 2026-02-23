using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _killDelay;
		private CBool _wasOverloaded;

		[Ordinal(107)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetProperty(ref _killDelay);
			set => SetProperty(ref _killDelay, value);
		}

		[Ordinal(108)] 
		[RED("wasOverloaded")] 
		public CBool WasOverloaded
		{
			get => GetProperty(ref _wasOverloaded);
			set => SetProperty(ref _wasOverloaded, value);
		}

		public NetrunnerChairControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
