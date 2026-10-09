/**
 * Runtime values and exact numeric types for generated Dataverse option sets.
 *
 * Import the value whose members you need, for example:
 * `import { account_accountcategorycode } from "./OptionSets";`
 */

export const account_accountcategorycode = {
  PreferredCustomer: 1,
  Standard: 2,
} as const;

export type account_accountcategorycode =
  (typeof account_accountcategorycode)[keyof typeof account_accountcategorycode];

export const account_accountclassificationcode = {
  DefaultValue: 1,
} as const;

export type account_accountclassificationcode =
  (typeof account_accountclassificationcode)[keyof typeof account_accountclassificationcode];

export const account_accountratingcode = {
  DefaultValue: 1,
} as const;

export type account_accountratingcode =
  (typeof account_accountratingcode)[keyof typeof account_accountratingcode];

export const account_address1_addresstypecode = {
  BillTo: 1,
  ShipTo: 2,
  Primary: 3,
  Other: 4,
} as const;

export type account_address1_addresstypecode =
  (typeof account_address1_addresstypecode)[keyof typeof account_address1_addresstypecode];

export const account_address1_freighttermscode = {
  FOB: 1,
  NoCharge: 2,
} as const;

export type account_address1_freighttermscode =
  (typeof account_address1_freighttermscode)[keyof typeof account_address1_freighttermscode];

export const account_address1_shippingmethodcode = {
  Airborne: 1,
  DHL: 2,
  FedEx: 3,
  UPS: 4,
  PostalMail: 5,
  FullLoad: 6,
  WillCall: 7,
} as const;

export type account_address1_shippingmethodcode =
  (typeof account_address1_shippingmethodcode)[keyof typeof account_address1_shippingmethodcode];

export const account_address2_addresstypecode = {
  DefaultValue: 1,
} as const;

export type account_address2_addresstypecode =
  (typeof account_address2_addresstypecode)[keyof typeof account_address2_addresstypecode];

export const account_address2_freighttermscode = {
  DefaultValue: 1,
} as const;

export type account_address2_freighttermscode =
  (typeof account_address2_freighttermscode)[keyof typeof account_address2_freighttermscode];

export const account_address2_shippingmethodcode = {
  DefaultValue: 1,
} as const;

export type account_address2_shippingmethodcode =
  (typeof account_address2_shippingmethodcode)[keyof typeof account_address2_shippingmethodcode];

export const account_businesstypecode = {
  DefaultValue: 1,
} as const;

export type account_businesstypecode =
  (typeof account_businesstypecode)[keyof typeof account_businesstypecode];

export const account_customersizecode = {
  DefaultValue: 1,
} as const;

export type account_customersizecode =
  (typeof account_customersizecode)[keyof typeof account_customersizecode];

export const account_customertypecode = {
  Competitor: 1,
  Consultant: 2,
  Customer: 3,
  Investor: 4,
  Partner: 5,
  Influencer: 6,
  Press: 7,
  Prospect: 8,
  Reseller: 9,
  Supplier: 10,
  Vendor: 11,
  Other: 12,
} as const;

export type account_customertypecode =
  (typeof account_customertypecode)[keyof typeof account_customertypecode];

export const account_industrycode = {
  Accounting: 1,
  AgricultureandNonpetrolNaturalResourceExtraction: 2,
  BroadcastingPrintingandPublishing: 3,
  Brokers: 4,
  BuildingSupplyRetail: 5,
  BusinessServices: 6,
  Consulting: 7,
  ConsumerServices: 8,
  DesignDirectionandCreativeManagement: 9,
  DistributorsDispatchersandProcessors: 10,
  DoctorsOfficesandClinics: 11,
  DurableManufacturing: 12,
  EatingandDrinkingPlaces: 13,
  EntertainmentRetail: 14,
  EquipmentRentalandLeasing: 15,
  Financial: 16,
  FoodandTobaccoProcessing: 17,
  InboundCapitalIntensiveProcessing: 18,
  InboundRepairandServices: 19,
  Insurance: 20,
  LegalServices: 21,
  NonDurableMerchandiseRetail: 22,
  OutboundConsumerService: 23,
  PetrochemicalExtractionandDistribution: 24,
  ServiceRetail: 25,
  SIGAffiliations: 26,
  SocialServices: 27,
  SpecialOutboundTradeContractors: 28,
  SpecialtyRealty: 29,
  Transportation: 30,
  UtilityCreationandDistribution: 31,
  VehicleRetail: 32,
  Wholesale: 33,
} as const;

export type account_industrycode =
  (typeof account_industrycode)[keyof typeof account_industrycode];

export const account_ownershipcode = {
  Public: 1,
  Private: 2,
  Subsidiary: 3,
  Other: 4,
} as const;

export type account_ownershipcode =
  (typeof account_ownershipcode)[keyof typeof account_ownershipcode];

export const account_paymenttermscode = {
  Net30: 1,
  _210Net30: 2,
  Net45: 3,
  Net60: 4,
} as const;

export type account_paymenttermscode =
  (typeof account_paymenttermscode)[keyof typeof account_paymenttermscode];

export const account_preferredappointmentdaycode = {
  Sunday: 0,
  Monday: 1,
  Tuesday: 2,
  Wednesday: 3,
  Thursday: 4,
  Friday: 5,
  Saturday: 6,
} as const;

export type account_preferredappointmentdaycode =
  (typeof account_preferredappointmentdaycode)[keyof typeof account_preferredappointmentdaycode];

export const account_preferredappointmenttimecode = {
  Morning: 1,
  Afternoon: 2,
  Evening: 3,
} as const;

export type account_preferredappointmenttimecode =
  (typeof account_preferredappointmenttimecode)[keyof typeof account_preferredappointmenttimecode];

export const account_preferredcontactmethodcode = {
  Any: 1,
  Email: 2,
  Phone: 3,
  Fax: 4,
  Mail: 5,
} as const;

export type account_preferredcontactmethodcode =
  (typeof account_preferredcontactmethodcode)[keyof typeof account_preferredcontactmethodcode];

export const account_shippingmethodcode = {
  DefaultValue: 1,
} as const;

export type account_shippingmethodcode =
  (typeof account_shippingmethodcode)[keyof typeof account_shippingmethodcode];

export const account_statecode = {
  Active: 0,
  Inactive: 1,
} as const;

export type account_statecode =
  (typeof account_statecode)[keyof typeof account_statecode];

export const account_statuscode = {
  Active: 1,
  Inactive: 2,
} as const;

export type account_statuscode =
  (typeof account_statuscode)[keyof typeof account_statuscode];

export const account_territorycode = {
  DefaultValue: 1,
} as const;

export type account_territorycode =
  (typeof account_territorycode)[keyof typeof account_territorycode];

export const contact_accountrolecode = {
  DecisionMaker: 1,
  Employee: 2,
  Influencer: 3,
} as const;

export type contact_accountrolecode =
  (typeof contact_accountrolecode)[keyof typeof contact_accountrolecode];

export const contact_address1_addresstypecode = {
  BillTo: 1,
  ShipTo: 2,
  Primary: 3,
  Other: 4,
} as const;

export type contact_address1_addresstypecode =
  (typeof contact_address1_addresstypecode)[keyof typeof contact_address1_addresstypecode];

export const contact_address1_freighttermscode = {
  FOB: 1,
  NoCharge: 2,
} as const;

export type contact_address1_freighttermscode =
  (typeof contact_address1_freighttermscode)[keyof typeof contact_address1_freighttermscode];

export const contact_address1_shippingmethodcode = {
  Airborne: 1,
  DHL: 2,
  FedEx: 3,
  UPS: 4,
  PostalMail: 5,
  FullLoad: 6,
  WillCall: 7,
} as const;

export type contact_address1_shippingmethodcode =
  (typeof contact_address1_shippingmethodcode)[keyof typeof contact_address1_shippingmethodcode];

export const contact_address2_addresstypecode = {
  DefaultValue: 1,
} as const;

export type contact_address2_addresstypecode =
  (typeof contact_address2_addresstypecode)[keyof typeof contact_address2_addresstypecode];

export const contact_address2_freighttermscode = {
  DefaultValue: 1,
} as const;

export type contact_address2_freighttermscode =
  (typeof contact_address2_freighttermscode)[keyof typeof contact_address2_freighttermscode];

export const contact_address2_shippingmethodcode = {
  DefaultValue: 1,
} as const;

export type contact_address2_shippingmethodcode =
  (typeof contact_address2_shippingmethodcode)[keyof typeof contact_address2_shippingmethodcode];

export const contact_address3_addresstypecode = {
  DefaultValue: 1,
} as const;

export type contact_address3_addresstypecode =
  (typeof contact_address3_addresstypecode)[keyof typeof contact_address3_addresstypecode];

export const contact_address3_freighttermscode = {
  DefaultValue: 1,
} as const;

export type contact_address3_freighttermscode =
  (typeof contact_address3_freighttermscode)[keyof typeof contact_address3_freighttermscode];

export const contact_address3_shippingmethodcode = {
  DefaultValue: 1,
} as const;

export type contact_address3_shippingmethodcode =
  (typeof contact_address3_shippingmethodcode)[keyof typeof contact_address3_shippingmethodcode];

export const contact_customersizecode = {
  DefaultValue: 1,
} as const;

export type contact_customersizecode =
  (typeof contact_customersizecode)[keyof typeof contact_customersizecode];

export const contact_customertypecode = {
  DefaultValue: 1,
} as const;

export type contact_customertypecode =
  (typeof contact_customertypecode)[keyof typeof contact_customertypecode];

export const contact_educationcode = {
  DefaultValue: 1,
} as const;

export type contact_educationcode =
  (typeof contact_educationcode)[keyof typeof contact_educationcode];

export const contact_familystatuscode = {
  Single: 1,
  Married: 2,
  Divorced: 3,
  Widowed: 4,
} as const;

export type contact_familystatuscode =
  (typeof contact_familystatuscode)[keyof typeof contact_familystatuscode];

export const contact_gendercode = {
  Male: 1,
  Female: 2,
} as const;

export type contact_gendercode =
  (typeof contact_gendercode)[keyof typeof contact_gendercode];

export const contact_haschildrencode = {
  DefaultValue: 1,
} as const;

export type contact_haschildrencode =
  (typeof contact_haschildrencode)[keyof typeof contact_haschildrencode];

export const contact_leadsourcecode = {
  DefaultValue: 1,
} as const;

export type contact_leadsourcecode =
  (typeof contact_leadsourcecode)[keyof typeof contact_leadsourcecode];

export const contact_paymenttermscode = {
  Net30: 1,
  _210Net30: 2,
  Net45: 3,
  Net60: 4,
} as const;

export type contact_paymenttermscode =
  (typeof contact_paymenttermscode)[keyof typeof contact_paymenttermscode];

export const contact_preferredappointmentdaycode = {
  Sunday: 0,
  Monday: 1,
  Tuesday: 2,
  Wednesday: 3,
  Thursday: 4,
  Friday: 5,
  Saturday: 6,
} as const;

export type contact_preferredappointmentdaycode =
  (typeof contact_preferredappointmentdaycode)[keyof typeof contact_preferredappointmentdaycode];

export const contact_preferredappointmenttimecode = {
  Morning: 1,
  Afternoon: 2,
  Evening: 3,
} as const;

export type contact_preferredappointmenttimecode =
  (typeof contact_preferredappointmenttimecode)[keyof typeof contact_preferredappointmenttimecode];

export const contact_preferredcontactmethodcode = {
  Any: 1,
  Email: 2,
  Phone: 3,
  Fax: 4,
  Mail: 5,
} as const;

export type contact_preferredcontactmethodcode =
  (typeof contact_preferredcontactmethodcode)[keyof typeof contact_preferredcontactmethodcode];

export const contact_shippingmethodcode = {
  DefaultValue: 1,
} as const;

export type contact_shippingmethodcode =
  (typeof contact_shippingmethodcode)[keyof typeof contact_shippingmethodcode];

export const contact_statecode = {
  Active: 0,
  Inactive: 1,
} as const;

export type contact_statecode =
  (typeof contact_statecode)[keyof typeof contact_statecode];

export const contact_statuscode = {
  Active: 1,
  Inactive: 2,
} as const;

export type contact_statuscode =
  (typeof contact_statuscode)[keyof typeof contact_statuscode];

export const contact_territorycode = {
  DefaultValue: 1,
} as const;

export type contact_territorycode =
  (typeof contact_territorycode)[keyof typeof contact_territorycode];

export const powerpagelanguages = {
  Arabic: 1025,
  BulgarianBulgaria: 1026,
  CatalanCatalan: 1027,
  ChineseTraditional: 1028,
  CzechCzechRepublic: 1029,
  DanishDenmark: 1030,
  GermanGermany: 1031,
  GreekGreece: 1032,
  English: 1033,
  FinnishFinland: 1035,
  FrenchFrance: 1036,
  Hebrew: 1037,
  HungarianHungary: 1038,
  ItalianItaly: 1040,
  JapaneseJapan: 1041,
  KoreanKorea: 1042,
  DutchNetherlands: 1043,
  NorwegianBokmålNorway: 1044,
  PolishPoland: 1045,
  PortugueseBrazil: 1046,
  RomanianRomania: 1048,
  RussianRussia: 1049,
  CroatianCroatia: 1050,
  SlovakSlovakia: 1051,
  SwedishSweden: 1053,
  ThaiThailand: 1054,
  TurkishTürkiye: 1055,
  IndonesianIndonesia: 1057,
  UkrainianUkraine: 1058,
  SlovenianSlovenia: 1060,
  EstonianEstonia: 1061,
  LatvianLatvia: 1062,
  LithuanianLithuania: 1063,
  VietnameseVietnam: 1066,
  BasqueBasque: 1069,
  HindiIndia: 1081,
  MalayMalaysia: 1086,
  KazakhKazakhstan: 1087,
  GalicianSpain: 1110,
  ChineseChina: 2052,
  PortuguesePortugal: 2070,
  SerbianLatinSerbia: 2074,
  ChineseHongKongSAR: 3076,
  SpanishTraditionalSortSpain: 3082,
  SerbianCyrillicSerbia: 3098,
} as const;

export type powerpagelanguages =
  (typeof powerpagelanguages)[keyof typeof powerpagelanguages];
