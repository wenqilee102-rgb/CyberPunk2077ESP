using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScreenDisplayContextData : IScriptable
	{
		private CEnum<ScreenDisplayContext> _context;

		[Ordinal(0)] 
		[RED("Context")] 
		public CEnum<ScreenDisplayContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		public ScreenDisplayContextData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
