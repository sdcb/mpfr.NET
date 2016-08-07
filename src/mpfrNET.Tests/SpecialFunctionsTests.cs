﻿using FluentAssertions;
using NUnit.Framework;
using System.ArbitraryPrecision;

namespace mpfrNET.Tests
{
	public class SpecialFunctionsTests
	{
		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, double.NegativeInfinity)]
		[TestCase(1, 0)]
		[TestCase(-1, double.NaN)]
		[TestCase(0.4, -0.916290731874155065183527211768011071450101219908262467791967881980785365)]
		[TestCase(2, 0.693147180559945309417232121458176568075500134360255254120680009493393621)]
		[TestCase(9.999, 2.302485087993712325682657954670077243204266090894201900519238035204856264)]
		[TestCase(10, 2.302585092994045684017991454684364207601101488628772976033327900967572609)]
		[TestCase(1234567890123, 27.84174213824383077016756910641102321518881583014475063503496616649672166)]
		public void Can_Ln(double left, double result)
		{
			var x = (double)new BigDecimal(left).Ln();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, double.NegativeInfinity)]
		[TestCase(1, 0)]
		[TestCase(-1, double.NaN)]
		[TestCase(0.4, -1.321928094887362347870319429489390175864831393024580612054756395815934776)]
		[TestCase(1024, 10)]
		[TestCase(9.999, 3.321783818169317312667541759643564948423217700960905620325686812784034478)]
		[TestCase(10, 3.321928094887362347870319429489390175864831393024580612054756395815934776)]
		public void Can_Log2(double left, double result)
		{
			var x = (double)new BigDecimal(left).Log2();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, double.NegativeInfinity)]
		[TestCase(1, 0)]
		[TestCase(-1, double.NaN)]
		[TestCase(0.4, -0.397940008672037609572522210551013946463620237075782917379145077745783621)]
		[TestCase(1000, 3)]
		[TestCase(9.999, 0.999956568380192489615443955976192773326249274054297415662088936238659348)]
		public void Can_Log10(double left, double result)
		{
			var x = (double)new BigDecimal(left).Log10();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, 0)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, 1)]
		[TestCase(1, 2.718281828459045235360287471352662497757247093699959574966967627724076630)]
		[TestCase(-2, 0.135335283236612691893999494972484403407631545909575881468158872654073374)]
		[TestCase(4.999, 148.2648201253242342339591225627208985720458425149174668922941623858720050)]
		[TestCase(5, 148.41315910257660342111558004055227962348766759387898904675284511091206482)]
		[TestCase(9.999, 22004.45033857464715721623840438148225727827858565599427258232680618244485)]
		[TestCase(10, 22026.46579480671651695790064528424436635351261855678107423542635522520281)]
		public void Can_Exp(double left, double result)
		{
			var x = (double)new BigDecimal(left).Exp();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, 0)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, 1)]
		[TestCase(1, 2)]
		[TestCase(-2, 0.25)]
		[TestCase(4.999, 31.97782697569448070151613937163205819747369486211219520368146244813466876)]
		[TestCase(9.999, 1023.290463222223382448516459892225862319158235587590246517806798340309400)]
		public void Can_Exp2(double left, double result)
		{
			var x = (double)new BigDecimal(left).Exp2();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, 0)]
		[TestCase(double.PositiveInfinity, double.PositiveInfinity)]
		[TestCase(0, 1)]
		[TestCase(1, 10)]
		[TestCase(-2, 0.01)]
		[TestCase(4.999, 99770.00638225533171944219428537623105521186139457315462487823089094547653)]
		[TestCase(-3.999, 0.000100230523807789967191540488932811055405366845354216064641163485230474)]
		public void Can_Exp10(double left, double result)
		{
			var x = (double)new BigDecimal(left).Exp10();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, 0)]
		[TestCase(1, 0.841470984807896506652502321630298999622563060798371065672751709991910404)]
		[TestCase(-2, -0.909297426825681695396019865911744842702254971447890268378973011530967301)]
		[TestCase(4.99, -0.961712903426793497941146014411106681934080224160928287532493239748346422)]
		[TestCase(5, -0.958924274663138468893154406155993973352461543964601778131672454235102558)]
		[TestCase(-3.99, -0.961712903426793497941146014411106681934080224160928287532493239748346422)]
		[TestCase(-4, 0.756802495307928251372639094511829094135912887336472571485416773401310493)]
		public void Can_Sin(double left, double result)
		{
			var x = (double)new BigDecimal(left).Sin();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, 1)]
		[TestCase(1, 0.540302305868139717400936607442976603732310420617922227670097255381100394)]
		[TestCase(-2, -0.416146836547142386997568229500762189766000771075544890755149973781964936)]
		[TestCase(4.99, 0.274058919545427243963091597696947545799038797732465290829096959767037072)]
		[TestCase(5, 0.283662185463226264466639171513557308334422592252215944930359066586151456)]
		[TestCase(-3.99, -0.661178837774880066670050952010127451311206612244513169987254125516567261)]
		[TestCase(-4, -0.653643620863611914639168183097750381424133596646218247007010283852737655)]
		public void Can_Cos(double left, double result)
		{
			var x = (double)new BigDecimal(left).Cos();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, 0)]
		[TestCase(1, 1.557407724654902230506974807458360173087250772381520038383946605698861397)]
		[TestCase(-2, 2.185039863261518991643306102313682543432017746227663164562955869966773747)]
		[TestCase(4.99, -3.509146518646267387536600382600542853663235868893916368334918018877284240)]
		[TestCase(5, -3.380515006246585636982705879447343908709569208285459877176820980918346010)]
		[TestCase(-3.99, -1.134682910836536142332309242987146630132427147176134827387699219793091976)]
		[TestCase(-4, -1.157821282349577583137342418267323923119762767367142130084857189358985762)]
		public void Can_Tan(double left, double result)
		{
			var x = (double)new BigDecimal(left).Tan();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, 1)]
		[TestCase(1, 1.850815717680925617911753241398650193470396655094009298835158277858815411)]
		[TestCase(-2, -2.402997961722380989754600401420066226245121093154526013044400970212074081)]
		[TestCase(4.99, 3.648850406542753600826176994730971005212497882868187665616772052218629276)]
		[TestCase(5, 3.525320085816088406701801059963244258542819400176246001736148496225839140)]
		[TestCase(-3.99, -1.512450101042832629061907729351585341131537856806412129279105804289479990)]
		[TestCase(-4, -1.529885656466397574629510922937355047038800024369051625337920108755249546)]
		public void Can_Sec(double left, double result)
		{
			var x = (double)new BigDecimal(left).Sec();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, double.PositiveInfinity)]
		[TestCase(1, 1.188395105778121216261599452374551003527829834097962625265253666359184367)]
		[TestCase(-2, -1.099750170294616466756697397026312896658764443149845708742554443062569126)]
		[TestCase(4.99, -1.039811357876951842636100008918619086480954172138191196872410925471580705)]
		[TestCase(5, -1.042835212771405819783119855907759843972351752364546174404470858222228857)]
		[TestCase(-3.99, 1.332927540018903225330149439178690130422735775504814817468719637569059513)]
		[TestCase(-4, 1.321348708810902377696791756372864909930252037729668747102174016301533008)]
		public void Can_Csc(double left, double result)
		{
			var x = (double)new BigDecimal(left).Csc();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, double.PositiveInfinity)]
		[TestCase(1, 0.642092615934330703006419986594265620230278113918171379101162280426276856)]
		[TestCase(-2, 0.457657554360285763750277410432047276428486329231674329641392162636292270)]
		[TestCase(4.99, -0.284969577270821000176253437554051039533297497727383135794405510694470803)]
		[TestCase(5, -0.295812915532745540427767168082485286068234795481534895337877768521957001)]
		[TestCase(-3.99, -0.881303481747828373615531886873991007728174144071000748692988305135018662)]
		[TestCase(-4, -0.863691154450616613946514345940817633501765708497994417460781853665240738)]
		public void Can_Cot(double left, double result)
		{
			var x = (double)new BigDecimal(left).Cot();
			x.Should().Be(result);
		}

		[TestCase(double.NaN, double.NaN)]
		[TestCase(double.NegativeInfinity, double.NaN)]
		[TestCase(double.PositiveInfinity, double.NaN)]
		[TestCase(0, 1.570796326794896619231321691639751442098584699687552910487472296153908203)]
		[TestCase(0.1, 1.470628905633336822885798512187058123529908727457923369096448441117505529)]
		[TestCase(-0.2, 1.772154247585227410686447243857374852338622781089781296744723539609517577)]
		[TestCase(1, 0)]
		[TestCase(-2, double.NaN)]
		[TestCase(4.99, double.NaN)]
		[TestCase(5, double.NaN)]
		[TestCase(-3.99, double.NaN)]
		[TestCase(-4, double.NaN)]
		public void Can_Acos(double left, double result)
		{
			var x = (double)new BigDecimal(left).Acos();
			x.Should().Be(result);
		}

		[TestCase((ulong)0, (ulong)1)]
		[TestCase((ulong)1, (ulong)1)]
		[TestCase((ulong)2, (ulong)2)]
		[TestCase((ulong)3, (ulong)6)]
		[TestCase((ulong)4, (ulong)24)]
		[TestCase((ulong)5, (ulong)120)]
		[TestCase((ulong)10, (ulong)3628800)]
		public void Can_Fact(ulong left, ulong result)
		{
			var x = (ulong)new BigDecimal(left).Fact(left);
			x.Should().Be(result);
		}
	}
}