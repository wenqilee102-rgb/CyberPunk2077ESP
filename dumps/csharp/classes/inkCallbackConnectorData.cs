using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackConnectorData : IScriptable
	{
		private CHandle<IScriptable> _userData;

		[Ordinal(0)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		public inkCallbackConnectorData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
