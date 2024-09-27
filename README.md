# IT-Dev-Risk

Answer (1):

Implementation - OK Implemented


Answer (2):

To implement a IsPoliticallyExposed, the following tasks can be considered under normal circunstances:

(1) Add a ClientInfo.cs containing an Enum with status, 0 - NOTEXPOSED, 1 - PEP.

(2) Add a ClientInfo object to ITrade and Trade constructor.

(3) Add new input rules to get this information.

(4) Add new Process rules to process this information.

(5) Add new Output rules for this information.

(6) If it needs to be rushed, a new TradeStatus enum type can be considered for use, but it might carry future architectural problems, depending on the upcomming features.

(7) Unit test modules.

(8) Documentation of modules.

(9) Deliver it to CI environment.

(10) Communicate that the acceptance test is required for later steps.

