using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputSchemesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _device;
		private gamebbScriptID_Uint32 _scheme;
		private gamebbScriptID_Variant _initializedInputHintManagerList;

		[Ordinal(0)] 
		[RED("Device")] 
		public gamebbScriptID_Uint32 Device
		{
			get => GetProperty(ref _device);
			set => SetProperty(ref _device, value);
		}

		[Ordinal(1)] 
		[RED("Scheme")] 
		public gamebbScriptID_Uint32 Scheme
		{
			get => GetProperty(ref _scheme);
			set => SetProperty(ref _scheme, value);
		}

		[Ordinal(2)] 
		[RED("InitializedInputHintManagerList")] 
		public gamebbScriptID_Variant InitializedInputHintManagerList
		{
			get => GetProperty(ref _initializedInputHintManagerList);
			set => SetProperty(ref _initializedInputHintManagerList, value);
		}

		public InputSchemesDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
