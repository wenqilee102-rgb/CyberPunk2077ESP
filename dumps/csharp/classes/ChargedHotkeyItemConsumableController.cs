using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedHotkeyItemConsumableController : ChargedHotkeyItemBaseController
	{
		private CEnum<gamedataStatPoolType> _c_statPool;

		[Ordinal(45)] 
		[RED("c_statPool")] 
		public CEnum<gamedataStatPoolType> C_statPool
		{
			get => GetProperty(ref _c_statPool);
			set => SetProperty(ref _c_statPool, value);
		}

		public ChargedHotkeyItemConsumableController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
