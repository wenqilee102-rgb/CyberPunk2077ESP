using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRazerAnimation_NodeType : questIFXManagerNodeType
	{
		private CArray<questPlayRazerAnimation_NodeTypeParams> _playParams;
		private CArray<questStopRazerAnimation_NodeTypeParams> _stopParams;
		private CArray<questSetIdleRazerAnimation_NodeTypeParams> _idleParams;

		[Ordinal(0)] 
		[RED("playParams")] 
		public CArray<questPlayRazerAnimation_NodeTypeParams> PlayParams
		{
			get => GetProperty(ref _playParams);
			set => SetProperty(ref _playParams, value);
		}

		[Ordinal(1)] 
		[RED("stopParams")] 
		public CArray<questStopRazerAnimation_NodeTypeParams> StopParams
		{
			get => GetProperty(ref _stopParams);
			set => SetProperty(ref _stopParams, value);
		}

		[Ordinal(2)] 
		[RED("idleParams")] 
		public CArray<questSetIdleRazerAnimation_NodeTypeParams> IdleParams
		{
			get => GetProperty(ref _idleParams);
			set => SetProperty(ref _idleParams, value);
		}

		public questRazerAnimation_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
