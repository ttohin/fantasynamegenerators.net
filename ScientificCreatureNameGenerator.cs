namespace FantasyNameGenerators
{
    public class ScientificCreatureNameGenerator
    {
        private readonly string[] nm1 =
        {
            "Acanthuridae", "Achatina", "Achatinoidea", "Acinonyx", "Actinidia", "Aegypius",
            "Aepyceros", "Ailuropoda", "Ailurus", "Ajaja", "Alcelaphinae", "Alces", "Alligator", "Alopex", "Alouatta",
            "Ambystoma", "Amphiprioninae", "Anas", "Anguis", "Anisoptera", "Anthozoa", "Apatura", "Apis", "Apodemus",
            "Aptenodytes", "Arachnocampa", "Arctictis", "Arctocephalinae", "Ardeidae", "Arini", "Arvicola",
            "Astrochelys", "Atelerix", "Balaenoptera", "Balsenoptera", "Barbus", "Betta", "Bison", "Blattaria",
            "Bombina", "Bombus", "Bos", "Brachypelma", "Brachyura", "Branta", "Bubalus", "Bubo", "Bufo", "Buteo",
            "Cacajao", "Caelifera", "Caimaninae", "Callithrix", "Camelus", "Canis", "Canus", "Capra", "Caracal",
            "Carcharhinus", "Carcharodon", "Caridea", "Castor", "Casuarius", "Caudata", "Cavia", "Cebus",
            "Cephalopterus", "Ceratophrys", "Ceratotherium", "Cerura", "Cetorhinus", "Cettia", "Chaetodontidae",
            "Chamaeleonidae", "Chelonioidea", "Chelydridae", "Chilopoda", "Chinchilla", "Chiroptera", "Chlamydosaurus",
            "Chlamyphorus", "Chlorocebus", "Choeropsis", "Choloepus", "Cichlidae", "Cirripedia", "Civettictis",
            "Cnidaria", "Coccinellidae", "Coleoptera", "Connochaetes", "Coraciiformes", "Coturnix", "Crocodylus",
            "Crocuta", "Cryptoprocta", "Cuon", "Cygnus", "Dasyatis", "Dasypodidae", "Dasyurus", "Daubentonia",
            "Delphinus", "Demospongiae", "Dendrobatidae", "Dendrobranchiata", "Dermaptera", "Desmodontinae",
            "Dicerorhinus", "Diceros", "Didelphis", "Diomedeidae", "Diplopoda", "Diptera", "Dracaena", "Dromaius",
            "Dugong", "Dynastes", "Echinoidea", "Electrophorus", "Elephantulus", "Elephas", "Eleutherodactylus",
            "Emydidae", "Enhydra", "Ephemeroptera", "Equus", "Erethizon", "Erithacus", "Erythrocebus", "Esox",
            "Eudyptes", "Eudyptula", "Euptilotis", "Falconiforme", "Felis", "Formicidae", "Fratercula", "Fregata",
            "Funambulus", "Galeocerdo", "Gallinula", "Gallus", "Gavia", "Gavialis", "Gekkonidae", "Geochelone",
            "Gerbillinae", "Gerridae", "Ginglymostoma", "Giraffa", "Gliridae", "Gopherus", "Gorilla", "Gruidae", "Gulo",
            "Gynnidomorpha", "Halichoerus", "Helarctos", "Heleioporus", "Heloderma", "Helogale", "Hemigalus",
            "Heterodontus", "Hieraatus", "Hippocampus", "Hippopotamus", "Holothuroidea", "Homo", "Hydrochoerus",
            "Hydrodamalis", "Hydrurga", "Hyla", "Hylobatidae", "Hymenoptera", "Iguana", "Indri", "Insecta", "Isoptera",
            "Labridae", "Lacerta", "Lacertilia", "Lagenorhynchus", "Lagothrix", "Lama", "Larva", "Latrodectus", "Lemmus",
            "Lemur", "Leontopithecus", "Leopardus", "Lepisosteidae", "Leptailurus", "Lepus", "Limulidae", "Lissotriton",
            "Litoria", "Lopholithodes", "Loxodonta", "Lucanidae", "Luscinia", "Lutra", "Lycaon", "Lynx", "Macaca",
            "Macropus", "Mammuthus", "Mandrillus", "Manta", "Megadyptes", "Megaptera", "Meleagris", "Melopsittacus",
            "Mephitis", "Merops", "Mesobatrachia", "Mesocricetus", "Metynnis", "Microcebus", "Mirounga", "Moloch",
            "Muraenidae", "Mustela", "Myrmecobius", "Myrmecophaga", "Nandinia", "Nasalis", "Nasua", "Nectophryne",
            "Neofelis", "Nephropidae", "Numididae", "Nyctereutes", "Ochotona", "Octopus", "Odobenus", "Odocoileus",
            "Okapia", "Oniscidea", "Ophisaurus", "Orcinus", "Oriolus", "Ornithorhynchus", "Oryctolagus", "Osteolaemus",
            "Ostreidae", "Otariidae", "Ovis", "Paguma", "Paguroidea", "Pan", "Panthera", "Papilionoidea", "Papio",
            "Paracheirodon", "Paradisaeidae", "Paradoxurus", "Paralichthys", "Passeridae", "Pavo", "Pecari", "Pelecanus",
            "Pelophylax", "Perameles", "Phacochoerus", "Phaethon", "Phalanger", "Phalangeriforme", "Pharomachrus",
            "Phascolarctos", "Phasianus", "Phasmatodea", "Phoca", "Phoenicopterus", "Phycodurus", "Physeter",
            "Physignathus", "Pica", "Picidae", "Platanistoidea", "Poecilia", "Pogona", "Pomacanthidae", "Pongo",
            "Prionailurus", "Pristella", "Procavia", "Procyon", "Proteus", "Protoreaster", "Pseudoryx", "Psittacine",
            "Pterois", "Pteromyini", "Pygocentrus", "Pygoscelis", "Ramphastos", "Rana", "Rangifer", "Raphus", "Rattus",
            "Recurvirostra", "Rhincodon", "Rhinoceros", "Rhinocerotidae", "Rhinoderma", "Rupicapra", "Saguinus",
            "Saimiri", "Sarcophilus", "Sciuridae", "Scorpaenidae", "Scorpiones", "Sepiida", "Serpentes", "Setonix",
            "Siluriformes", "Simia", "Smilodon", "Spermophilus", "Spheniscus", "Sphenodon", "Sphyraena", "Sphyrna",
            "Squalus", "Stegostoma", "Strigops", "Strix", "Struthio", "Sula", "Suricata", "Sus", "Symphysodon",
            "Syncerus", "Tachyglossus", "Talpidae", "Tamias", "Tapirus", "Tarsius", "Taxidea", "Tetraodontidae",
            "Tetraoninae", "Teuthida", "Threskiornithidae", "Thylogale", "Tragelaphus", "Tremarctos", "Trichechus",
            "Tridacna", "Trochilidae", "Troglodytes", "Tursiops", "Tyto", "Urochordata", "Uroplatus", "Ursidae", "Ursus",
            "Varanus", "Vespa", "Viverra", "Vombatus", "Vulpes", "Xenopus"
        };

        private readonly string[] nm2 =
        {
            "abelii", "acanthias", "aculeatus", "acutorostrata", "adeliae", "aegagrus", "afra", "africana", "africanus",
            "agassizii", "agilis", "ajaja", "alba", "albiventris", "alces", "alisman", "alpinus", "altaica", "aluco",
            "amblyrhynchos", "americanus", "amoyensis", "amphibius", "anatinus", "anguinus", "antarcticus", "antipodes",
            "arctica", "arcticus", "arctos", "argenteus", "aries", "asinus", "atratus", "auratus", "aurelia", "aureus",
            "axelrodi", "bactrianus", "barbus", "bengalensis", "berengei", "bicolor", "bicornis", "binotata", "binturong",
            "birostris", "bison", "borneensis", "brachyurus", "bubalis", "bufo", "buteo", "caballus", "caffer", "camelopardalis",
            "camelus", "canadensis", "capensis", "capucinus", "caracal", "carcharias", "catesbeiana", "catta", "centroura",
            "chrysocome", "chrysolophus", "cinereus", "cirratum", "civetta", "colchicus", "concolor", "corbetti", "coturnix",
            "cristatus", "crocuta", "cucullatus", "cuniculus", "cuvier", "cyclotis", "darwinii", "deliciosa", "delphis", "demersus",
            "derbyanus", "diehli", "dingo", "diphone", "domesticus", "dorsaum", "dromedarius", "dugon", "electricus", "elegans",
            "eques", "equus", "erminea", "esculentus", "europaeus", "eurycerus", "falconeri", "familiaris", "fasciatum", "fasciatus",
            "fascicularis", "ferox", "forsteri", "fragilis", "francisci", "fulgens", "fulica", "furo", "fuscata", "gallus",
            "gangeticus", "geoffroyi", "gigantea", "giganteus", "gigas", "glama", "gorilla", "graueri", "grevyi", "grunniens",
            "grypus", "guianensis", "gulo", "habroptilus", "harrisii", "hercules", "hermaphroditus", "hircus", "hoffmani",
            "horriblis", "horridus", "humboldti", "hydrochaeris", "iberia", "iguana", "immer", "imperator", "indicus",
            "indri", "iris", "jacksoni", "johnstoni", "jubatus", "kingii", "komodoensis", "laevis", "lagopus", "lagotricha",
            "lanigera", "larvata", "larvatus", "latrans", "lemmus", "leo", "leptonyx", "lessonae", "leucas", "liberiensis",
            "lotor", "luminosa", "lupus", "lutris", "lynx", "macrocephalus", "maculatus", "magarhynchos", "magellanicus",
            "malayanus", "manatu", "mandarinia", "mandtii", "marinus", "maritimus", "maxillaris", "maximus", "melampus",
            "melanoleuca", "mendiculus", "mephitis", "mexicanum", "midas", "minor", "monachus", "mule", "murinus", "musculus",
            "nasua", "nasuta", "nattereri", "neanderthalensis", "nebouxii", "nebulosa", "nghetinhensis", "nigra", "nivalis",
            "nodosus", "novaeangliae", "novaehollandiae", "obscurus", "occidentalis", "oedipus", "onca", "orca", "orientalis",
            "oriolus", "ornata", "ornatus", "palmarum", "paniscus", "papua", "pardalis", "pardus", "parvula", "patagonicus",
            "patas", "physalus", "pica", "pictus", "platyrhynchos", "populator", "porcellus", "primigenius", "procyonoides",
            "punctatus", "putorius", "pygerythrus", "pygmaea", "pygmaeus", "quagga", "radiata", "rattus", "reticulata",
            "richardsonii", "ridibundus", "robustus", "rosalia", "rosmarus", "rubecula", "rufus", "rupicapra", "sapiens",
            "scandiacus", "schlegeli", "scrofa", "scyphozoa", "serval", "simum", "smithi", "sondaicus", "sphinx", "spilogaster",
            "splendens", "strepsiceros", "striatus", "sulfuratus", "sumatrae", "sumatranus", "sumatrensis", "suricatta",
            "suspectum", "sylvaticus", "tajacu", "tangalunga", "tarandus", "taurinus", "taurus", "taxus", "temporaria",
            "tetraspis", "tibetanus", "tigrinum", "tigris", "toco", "tridactyla", "troglodytes", "truncatus", "typus",
            "undulatus", "unicornis", "ursinus", "vinula", "virginiana", "vitticeps", "vitulina", "viverrinus", "volitans",
            "vulgaris", "vulpes", "zebra", "zerda", "zygaena"
        };

        private readonly string[] nm3 =
        {
            "Acanth", "Ach", "Achat", "Acin", "Act", "Aeg", "Aepyc", "Ail", "Ailur", "Aj", "Al", "Alc", "Alcel", "All", "Amb", "Amphipr",
            "An", "Ang", "Anis", "Anth", "Ap", "Apat", "Apod", "Apten", "Ar", "Arachn", "Arct", "Arctoc", "Ard", "Arv", "Astr", "Atel",
            "Balaen", "Balsen", "Barb", "Bett", "Bis", "Blatt", "Bomb", "Bos", "Br", "Brach", "Bub", "Buf", "But", "Cac", "Cael", "Caim",
            "Call", "Cam", "Can", "Capr", "Car", "Carch", "Cas", "Cast", "Caud", "Cav", "Ceb", "Cephal", "Cer", "Cerat", "Cet", "Cett",
            "Chaetod", "Chamael", "Chel", "Chelon", "Chil", "Chinch", "Chiropt", "Chlam", "Chlamyd", "Chlor", "Choer", "Chol", "Cichl",
            "Cirr", "Civett", "Cnid", "Coccin", "Coleopt", "Connoch", "Corac", "Cot", "Croc", "Crocod", "Crypt", "Cuon", "Cygn", "Das",
            "Dasyp", "Daubent", "Delph", "Demosp", "Dendrob", "Dendrobr", "Derm", "Desmod", "Dic", "Dicer", "Did", "Diom", "Dipl", "Dipt",
            "Drac", "Drom", "Dug", "Dyn", "Echin", "Electr", "Eleph", "Eleuther", "Emyd", "Enh", "Ephem", "Eq", "Ereth", "Erith", "Erythr",
            "Es", "Eud", "Eupt", "Falcon", "Fel", "Formic", "Frat", "Freg", "Fun", "Galeoc", "Gall", "Gallin", "Gav", "Gekkon", "Geoch",
            "Gerb", "Gerr", "Ginglym", "Gir", "Glir", "Goph", "Gor", "Gruid", "Gul", "Gynnid", "Halich", "Hel", "Heleiop", "Helod",
            "Helog", "Hemig", "Heter", "Hier", "Hipp", "Hippop", "Holoth", "Hom", "Hydr", "Hydrod", "Hyl", "Hylob", "Hymen", "Iguan",
            "Indr", "Ins", "Isopt", "Labr", "Lac", "Lacert", "Lag", "Lagenorh", "Lam", "Larv", "Latr", "Lem", "Lemm", "Leontop", "Leop",
            "Lep", "Lepis", "Lept", "Limul", "Liss", "Lit", "Lophol", "Loxod", "Lucan", "Lusc", "Lutr", "Lyc", "Lynx", "Mac", "Macr",
            "Mammuth", "Mandr", "Mant", "Megad", "Megapt", "Meleagr", "Melops", "Meph", "Mer", "Mesobatr", "Mesocr", "Met", "Microc",
            "Mir", "Mol", "Muraen", "Must", "Myrmec", "Nand", "Nas", "Nectophr", "Neof", "Nephr", "Numid", "Nycter", "Ochot", "Octop",
            "Odob", "Odoc", "Okap", "Onisc", "Ophis", "Orc", "Oriol", "Ornithorh", "Oryct", "Osteol", "Ostr", "Otar", "Ov", "Pag", "Pagur",
            "Pan", "Panth", "Pap", "Papilion", "Parach", "Paradis", "Paradox", "Paral", "Pass", "Pav", "Pec", "Pelec", "Peloph", "Peram",
            "Phacoch", "Phaeth", "Phal", "Phalanger", "Pharom", "Phas", "Phascol", "Phasmat", "Phoc", "Phoenic", "Phycod", "Phys",
            "Physign", "Pic", "Platan", "Poec", "Pog", "Pomac", "Pong", "Prion", "Prist", "Proc", "Prot", "Protor", "Pseud", "Psitt",
            "Pter", "Pterom", "Pygoc", "Pygosc", "Ramph", "Ran", "Rang", "Raph", "Ratt", "Recurv", "Rhinc", "Rhinoc", "Rhinocer", "Rhinod",
            "Rupic", "Sag", "Saim", "Sarcoph", "Sciur", "Scorp", "Sep", "Serp", "Set", "Silurif", "Sim", "Smil", "Spermoph", "Sph",
            "Sphen", "Sphyr", "Squal", "Stegost", "Strig", "Strix", "Struth", "Sul", "Suric", "Sus", "Symph", "Sync", "Tachyg", "Talp",
            "Tam", "Tap", "Tars", "Tax", "Tetraod", "Tetraon", "Teuth", "Threskiorn", "Thyl", "Tragel", "Trem", "Trich", "Trid", "Troch",
            "Trogl", "Turs", "Tyt", "Uroch", "Uropl", "Urs", "Var", "Vesp", "Viv", "Vomb", "Vulp", "Xenop"
        };

        private readonly string[] nm4 =
        {
        };
    }
}