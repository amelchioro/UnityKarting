/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID ANIMAL_BIG_BIRDS_PASSBY = 1252856926U;
        static const AkUniqueID ANIMAL_BUTTERFLIES = 2398951133U;
        static const AkUniqueID BAR_RESTAURANT_CROWD = 1223201024U;
        static const AkUniqueID CHANGE_AMBIENT_TRIGGER = 2959269517U;
        static const AkUniqueID CHECKPOINT_YELLOW = 1426218890U;
        static const AkUniqueID CIRCUITMUSICSTART = 2761973765U;
        static const AkUniqueID CRASH_BILLBOARD = 3522116982U;
        static const AkUniqueID CRASH_CIRCUIT = 447680482U;
        static const AkUniqueID ENGINE_START = 2862969430U;
        static const AkUniqueID EXCLAMATION_MARK = 2569540472U;
        static const AkUniqueID FINISHEDLASTLAP = 359432598U;
        static const AkUniqueID FIREWORKS_START = 3951643844U;
        static const AkUniqueID GAME_START = 733168346U;
        static const AkUniqueID IA_ENGINE_START = 1269625109U;
        static const AkUniqueID KART_LANDING = 3852706935U;
        static const AkUniqueID LAKE_FOREST = 3676383412U;
        static const AkUniqueID LAMPIONE = 3649808752U;
        static const AkUniqueID LOOPTEST = 2249821623U;
        static const AkUniqueID MAIN_AMB = 274413203U;
        static const AkUniqueID MATERIALROADATTRITO = 1040646485U;
        static const AkUniqueID MENU_BACK = 3063554414U;
        static const AkUniqueID MENU_CONTROLS = 849277653U;
        static const AkUniqueID MENU_MOUSE_OVER = 2785341881U;
        static const AkUniqueID MENU_PLAY = 105544633U;
        static const AkUniqueID MENU_SCREENSHOT = 3996466371U;
        static const AkUniqueID MENU_TAB_CLOSE = 2339433701U;
        static const AkUniqueID MENU_TAB_OPEN = 1332629231U;
        static const AkUniqueID MENU_TICK = 1532143380U;
        static const AkUniqueID MENUMUSIC = 679636833U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID NEW_LAP = 1585951119U;
        static const AkUniqueID RAMP = 2110514317U;
        static const AkUniqueID SKID = 822292696U;
        static const AkUniqueID SPEED_BOOST = 3189989926U;
        static const AkUniqueID SPEED_BOOST_EMITTER = 942451613U;
        static const AkUniqueID SPEED_SLOW = 796148322U;
        static const AkUniqueID SPEED_SLOWDOWN_EMITTER = 3976930737U;
        static const AkUniqueID STARTRACE = 2575303448U;
        static const AkUniqueID TEST = 3157003241U;
        static const AkUniqueID THIRDLAP = 1568327959U;
        static const AkUniqueID TV_CAR_PASSBY = 4238077199U;
        static const AkUniqueID TV_TRANSMISSION = 83565370U;
        static const AkUniqueID UCCELLINI_TEST = 486380656U;
        static const AkUniqueID WINGAME = 3258849071U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace ALTITUDE
        {
            static const AkUniqueID GROUP = 1141543723U;

            namespace STATE
            {
                static const AkUniqueID HIGH = 3550808449U;
                static const AkUniqueID LOW = 545371365U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace ALTITUDE

        namespace AMBIENTE
        {
            static const AkUniqueID GROUP = 4095160060U;

            namespace STATE
            {
                static const AkUniqueID CITY = 3888786832U;
                static const AkUniqueID DESERT = 1850388778U;
                static const AkUniqueID FOREST = 491961918U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace AMBIENTE

        namespace MUSICCONTROL
        {
            static const AkUniqueID GROUP = 452733453U;

            namespace STATE
            {
                static const AkUniqueID CIRCUITSTART = 668771194U;
                static const AkUniqueID GAMESTART = 4058101365U;
                static const AkUniqueID HOMEMENU = 3279461033U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID WIN = 979765101U;
            } // namespace STATE
        } // namespace MUSICCONTROL

        namespace PAUSE
        {
            static const AkUniqueID GROUP = 3092587493U;

            namespace STATE
            {
                static const AkUniqueID NO = 1668749452U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID YES = 979470758U;
            } // namespace STATE
        } // namespace PAUSE

        namespace SKIDON
        {
            static const AkUniqueID GROUP = 1883672139U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OFF = 930712164U;
                static const AkUniqueID ON = 1651971902U;
            } // namespace STATE
        } // namespace SKIDON

    } // namespace STATES

    namespace SWITCHES
    {
        namespace ENGINE_LOAD
        {
            static const AkUniqueID GROUP = 1993809446U;

            namespace SWITCH
            {
                static const AkUniqueID OFFLOAD = 2987420976U;
                static const AkUniqueID ONLOAD = 2466053606U;
            } // namespace SWITCH
        } // namespace ENGINE_LOAD

        namespace REVERSE
        {
            static const AkUniqueID GROUP = 3260481321U;

            namespace SWITCH
            {
                static const AkUniqueID REVERSEOFF = 3315097688U;
                static const AkUniqueID REVERSEON = 2560277890U;
            } // namespace SWITCH
        } // namespace REVERSE

        namespace ROADMATERIAL
        {
            static const AkUniqueID GROUP = 1377718168U;

            namespace SWITCH
            {
                static const AkUniqueID CITY_STREET = 2554393810U;
                static const AkUniqueID FOREST_STREET = 418560256U;
                static const AkUniqueID RAMP = 2110514317U;
                static const AkUniqueID SAND = 803837735U;
            } // namespace SWITCH
        } // namespace ROADMATERIAL

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MUSICPLAYBACKSPEED = 1440783398U;
        static const AkUniqueID RTPC_RPM = 3774151474U;
        static const AkUniqueID SPEED = 640949982U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID STATECHANGEWOOSH = 2272290976U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID AMBIENCE = 85412153U;
        static const AkUniqueID GAME = 702482391U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID SFX = 393239870U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID OPENSPACE = 920540693U;
        static const AkUniqueID TUNNEL = 3059984139U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
