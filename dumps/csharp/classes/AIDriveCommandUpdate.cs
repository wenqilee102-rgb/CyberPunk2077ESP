using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveCommandUpdate : IScriptable
	{
		private CFloat _minSpeed;
		private CFloat _maxSpeed;
		private CBool _clearTrafficOnPath;

		[Ordinal(0)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(2)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		public AIDriveCommandUpdate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
