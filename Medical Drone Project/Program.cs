using System;

namespace Medical_Drone_PRoject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts user to input specified abbreviated codes
            // if user does not know what the codes mean they may type help to describe what the codes indicate
            Console.WriteLine("Medical Drone Project");
            Console.WriteLine("What is the emegency: ami, hss, aas, sl, opw, cva, 23b, od, ht, bjm or help:  ");
            string userValue = Console.ReadLine();

            string message = "";

            // depending on user input the message will read the condition and treatment that will be sent via drone
            if (userValue == "ami")
            {
                message = "\nHeart attack: Difibrillator \n \nCheck that the wires from the electrodes are connected to the AED. " +
                   "Make sure no one is touching the person, and then press the AED's analyze button. " +
                   "Stay clear while the machine checks the \nperson's heart rhythm. " +
                   "If a shock is needed, the AED will let you know when to deliver it.";
            }
            else if (userValue == "hss")
                message = "\nHyperglycemia (low blood pressure): Insulin \n   " +
                    "\nStep 1: Remove pen cover or cap. \nIf using milky-white (intermediate-acting) insulin, gently roll pen between palms 15 seconds to mix." + "\n     " +
                    "\nStep 2: Get the needle ready. \nA. Pull paper tab off pen needle. \nB. Screw needle onto insulin end of pen. \nC. Remove outer needle cover. \nD. Remove inner needle cover to expose the needle. " +
                    "Throw inner needle cover in trash.   \n  " +
                    "\nStep 3: Get the pen ready.   \nA. Prime the pen and clear air from needle. This adjusts the pen and needle for good accuracy when it's time to measure " +
                    "your insulin dose. Turn the dose selector knob at end of the pen to \n1 or 2 units (watch dose markings change with turning of knob). \nB. Hold the pen with needle pointing upward. Press dose knob up " +
                    "completely while watching for insulin drop or stream to appear. Repeat, if necessary, until insulin is seen at needle tip. \nThe dial should be back at zero after completing the priming step. \n " +
                    "\nStep 4: Turn dose knob to dial in your insulin dose. (You can dial backward, too.) The pen will allow you to receive only the amount that you have set. \nDouble-check the dose window to assure your proper dose. \n" +
                    "\nStep 5: Select an injection site. The abdomen is the preferred place for many types of insulin--between the bottom of the ribs and pubic line, avoiding 3-4 inches surrounding the navel. The top of the thighs and " +
                    "back of upper arms \n \nStep 6: Inject insulin. \nA. Curl fingers around the upper end of the pen to hold secure. Poise thumb, in air, above dose knob. \nB. Gently pinch up skin with your free hand. " +
                    "\nC. Quickly insert the needle at a 90-degree angle. Release the pinch. \nD. Use your thumb to press down on the dose knob until it stops (the dose window will be back at zero). Leave the needle in place for 5-10 " +
                    "seconds to help prevent insulin from leaking out of the \ninjection spot (see package insert to learn timing recommendation for your pen). \nPull the needle straight out of the skin. It is normal to sometimes see a small" +
                    " drop of blood or bruise. \nYou may lightly pat the site with a tissue or cotton ball, but do not massage the area.Place outer needle cover over needle and twist to unscrew needle from pen. \nThrow used needle away in hard " +
                    "container (an empty pill container or detergent jug are safe examples). Put the outer needle cover back on the pen. " +
                    "\n \nCongratulations, you're done! Please Remain with patient until emergency services arrives.";

            else if (userValue == "aas")
                message = "Anaphylactic Shock (allergic reaction): Epinephrine auto-injector (EpiPen) \n" +
                    "\nGet them into a comfortable position and elevate their legs. This keeps blood flowing to the vital organs." +
                    "\nIf they have an EpiPen, administer it immediately. DO NOT administer more then one unless directed by a medical professional." +
                    "\nGive them CPR if they are not breathing until the emergency medical team arrives." +
                    "\n \nHow to administer CPR \nStep 1: Push hard, push fast. Place your hands, one on top of the other, in the middle of the chest. Use your body weight to help you administer compressions that are at least 2 inches " +
                    "\ndeep and delivered at a rate of at least 100 compressions per minute. \n \nStep 2: Deliver rescue breaths. With the person's head tilted back slightly and the chin lifted, pinch the nose shut and place your mouth over the person's mouth to make a complete seal." +
                    "\nBlow into the person's mouth to make the chest rise. Deliver two rescue breaths, then continue compressions.\n \nSpecial Note: If the chest does not rise with the initial rescue breath, re-tilt the head before delivering the second breath. \nIf the chest " +
                    "doesn't rise with the second breath, the person may be choking. \nAfter each subsequent set of 100 chest compressions, and before attempting breaths, look for an object and, if seen, remove it. \n \nStep 3: Continue CPR steps. Keep performing cycles of chest " +
                    "compressions and breathing until the person exhibits signs of life, such as breathing, an AED becomes available, or \nEMS or a trained medical responder arrives on scene.";


            else if (userValue == "sl")
                message = "Severed Limb: Tourniquet \n \nStep 1: Check the person's airway (open if necessary); check breathing and circulation. If necessary, begin rescue breathing, cardiopulmonary resuscitation (CPR), or bleeding control. \n" +
                    "\nStep 2: Try to calm and reassure the person as much as possible. Amputation is painful and very frightening. \n" +
                    "\nStep 3: Control bleeding by applying direct pressure to the wound. Raise the injured area. If bleeding continues, recheck the source of the bleeding \n" +
                    "and reapply direct pressure, with help from someone who is not tired. If the person has life-threatening bleeding, a tight bandage or tourniquet will \n" +
                    "be easier to use than direct pressure on the wound. However, using a tight bandage for a long time may do more harm than good \n" +
                    "\nStep 4: Save any severed body parts and make sure they stay with the person. If possible, remove any dirty material that can" +
                    "\ncontaminate the wound, then gently rinse the body part if the cut end is dirty\n" +
                    "\nStep 5: Wrap the severed part in a clean, damp cloth, place it in a sealed plastic bag and place the bag in an ice water bath.\n" +
                    "\nStep 6: DO NOT put the body part directly in water without using a plastic bag. \n" +
                    "\nStep 7: DO NOT put the severed part directly on ice. DO NOT use dry ice as this will cause frostbite and injury to the part.\n" +
                    "\nStep 8: If cold water is not available, keep the part away from heat as much as possible. Save it for the medical team, or take it to the hospital. \nCooling the severed part allows reattachment to be done at a later time. /n" +
                    "Without cooling, the severed part is only good for reattachment for about 4 to 6 hours. \n" +
                    "\nStep 9: Keep the person warm.\n" +
                    "\nStep 10: Take steps to prevent shock. Lay the person flat, raise the feet about 12 inches (30 centimeters), and cover the person with a coat or blanket. \nDO NOT place the person in this position if a head, neck, back, or " +
                    "\nleg injury is suspected or if it makes the victim uncomfortable\n" +
                    "\nStep 11: Once the bleeding is under control, check the person for other signs of injury that require emergency treatment. \n" +
                    "Treat fractures, additional cuts, and other injuries appropriately. \n" +
                    "\nStep 12: Stay with the person until medical help arrives." +
                    "\n \n \nDO NOT: \n" +
                    "DO NOT forget that saving the person's life is more important than saving a body part \n" +
                    "DO NOT overlook other, less obvious, injuries.\n" +
                    "DO NOT attempt to push any part back into place \n" +
                    "DO NOT decide that a body part is too small to save. \n" +
                    "DO NOT place a tourniquet, unless the bleeding is life threatening, as the entire limb may be harmed. \n" +
                    "DO NOT raise false hopes of reattachment.";

            else if (userValue == "opw")
                message = "\nOpen Chest Wound (Gun shot Wound): XSTAT 30 (Sponge-Filled Syringe) \n" +
                    "\nStep 1: Open the package and remove applicator. \n" +
                    "\nStep 2: Pull the black handle out and away from barrel until it stops and locks. \n" +
                    "\nStep 3: Place the tip of the applicator into the wound track as close to the bleeding source as possible. \n" +
                    "\nStep 4: Firmly depress black handle to deploy sponges into the wound.Material should flow freely into the wound." +
                    "\nDeploy XSTAT within 30 seconds of insertion into wound. \n" +
                    "\nDO NOT attempt to forcefully eject the material from the applicator. If resistance is met, pull back slightly " +
                    "\non the applicator body to create additional packing space, then continue to depress handle. \n" +
                    "\nStep 5: Use additional applicators as necessary to completely pack the wound with sponges." +
                    "\n \nDO NOT attempt to remove sponges from wound. Sponges must be removed intraoperatively " +
                    "\nby surgeon with the capability and equipment for achieving proximal and distal vascular control. \n" +
                    "\nStep 6: Cover the wound with an occlusive or pressure dressing. If available, use an elastic bandage.\n" +
                    "\nStep 7: If bleeding persists, apply manual pressure until bleeding is controlled. \n" +
                    "\nStep 8: Remove the included casualty card from the pouch located underneath this label. " +
                    "\nAssess patient for peripheral circulation and document presence of distal pulse on included casualty card." +
                    "\nWARNING: Vascular compression greater than four hours is not recommended due to concerns related to limb ischemia. \n" +
                    "\nStep 9: Document clinical assessments, treatments rendered, and changes in the casualty status " +
                    "\non the included casualty card. Forward this information with the casualty to the next level of care. \n" +
                    "\nWARNING: Triangular segments of the applicator tip may break away from applicator during treatment.If this occurs, " +
                    "\ndo not attempt to retrieve it from the wound.Record number of separated applicator tips on casualty card.\n" +
                    "\nRemain with patient until certified personel arrives. ";

            else if (userValue == "cva")
                message = "\nCerebrovascular Accident (stroke) = CPR \n" +
                    "\nStep 1: If the person is conscious, lay them down on their side with their head slightly raised and supported. \n" +
                    "\nStep 2: Do not give them anything to eat or drink.  Loosen any restrictive clothing that could cause breathing difficulties." +
                    "\nIf weakness is obvious in any limb, support it and avoid pulling on it when moving the person.\n" +
                    "\nStep 3: If they are unconscious, check their breathing and pulse and put them on their side." +
                    "\nIf they do not have a pulse or are not breathing start CPR straight away. \n" +
                    "\nHow to administer CPR \nStep 1: Push hard, push fast. Place your hands, one on top of the other, in the middle of the chest. Use your body weight to help you administer compressions that are at least 2 inches " +
                    "\ndeep and delivered at a rate of at least 100 compressions per minute. \n \nStep 2: Deliver rescue breaths. With the person's head tilted back slightly and the chin lifted, pinch the nose shut and place your mouth over the person's mouth to make a complete seal." +
                    "\nBlow into the person's mouth to make the chest rise. Deliver two rescue breaths, then continue compressions.\n \nSpecial Note: If the chest does not rise with the initial rescue breath, re-tilt the head before delivering the second breath. \nIf the chest " +
                    "doesn't rise with the second breath, the person may be choking. \nAfter each subsequent set of 100 chest compressions, and before attempting breaths, look for an object and, if seen, remove it. \n \nStep 3: Continue CPR steps. Keep performing cycles of chest " +
                    "compressions and breathing until the person exhibits signs of life, such as breathing, an AED becomes available, or \nEMS or a trained medical responder arrives on scene.";

            else if (userValue == "23b")
                message = "\n2nd & 3rd Degree Burns = Sterile Bandages & Emergency Blanket. \n" +
                    "\nFor Second-Degree Burn (Affecting Top 2 Layers of Skin) \n" +
                    "\nStep 1: Cool Burn \n" +
                    "\n     a. Immerse in cool water for 10 or 15 minutes." +
                    "\n     b. Use compresses if running water is not available." +
                    "\n     c. Do not apply ice. It can lower body temperature and cause further damage." +
                    "\n     d. Do not break blisters or apply butter or ointments, which can cause infection. \n" +
                    "\nStep 2: Protect Burn \n" +
                    "\n     a. Cover loosely with sterile, nonstick bandage and secure in place with gauze or tape.\n" +
                    "\nStep 3: Prevent Shock \n" +
                    "\nUnless the person has a head, neck, or leg injury, or it would cause discomfort: \n" +
                    "\n     a. Lay the person flat." +
                    "\n     b. Elevate feet about 12 inches." +
                    "\n     c. Elevate burn area above heart level, if possible." +
                    "\n     d. Cover the person with coat or blanket. \n" +
                    "\nStep 4: See a Doctor \n" +
                    "\n     a. The doctor can test burn severity, prescribe antibiotics and pain medications, and administer a tetanus shot, if needed.\n" +
                    "\n" +
                    "\nFor Third-Degree Burn \n" +
                    "\nStep 1: Call 911 \n" +
                    "\nStep 2: Protect Burn Area \n" +
                    "\n     a. Cover loosely with sterile, nonstick bandage or, for large areas, a sheet or other material that that would not leave lint in wound." +
                    "\n     b. Separate burned toes and fingers with dry, sterile dressings." +
                    "\n     c. Do not soak burn in water or apply ointments or butter, which can cause infection. \n" +
                    "\nStep 3: Prevent Shock\n" +
                    "\nUnless the person has a head, neck, or leg injury or it would cause discomfort: \n" +
                    "\n     a. Lay the person flat." +
                    "\n     b. Elevate burn area above heart level, if possible." +
                    "\n     c. Cover the person with coat or blanket." +
                    "\n     d. For an airway burn, do not place pillow under the person's head when the person is lying down. This can close the airway." +
                    "\n     e. Have a person with a facial burn sit up." +
                    "\n     f. Check pulse and breathing to monitor for shock until emergency help arrives. \n" +
                    "\nStep 4: See a Doctor \n" +
                    "\n     a. Doctors will give oxygen and fluid, if needed, and treat the burn.";

            else if (userValue == "od")
                message = "\nDrug Overdose = Activated charcoal \n" +
                    "\nIf you think someone has taken an overdose: \n" +
                    "\nStep 1: Stay Calm \n" +
                    "\nStep 2: Call an ambulance on triple zero (000).\n" +
                    "\nStep 3: If the person is unconscious but breathing, place them on their side in the recovery position. Make sure that the airway " +
                    "\nremains open by tilting the head back and lifting the chin. Check breathing and monitor their condition until help arrives." +
                    "\nDo not try to make the person vomit. \n" +
                    "\nStep 4: Do not try to make the person vomit. \n" +
                    "\nStep 5: Do not give them anything to eat or drink. \n" +
                    "\nStep 6: Bring the pill containers to hospital. \n" +
                    "\nStep 7: Even if the person seems okay, call the Poisons Information Centre on 13 11 26 for advice on what to do to help. " +
                    "\nThe centre is open 24 hours, 7 days a week.";

            else if (userValue == "ht")
                message = "\nHeat Related Injury: Drinkable Intravenous (IV) With Cold Packs \n" +
                    "\nStep 1: Move the person into a cool place, out of direct sunlight. \n" +
                    "\nStep 2: Remove the person's unnecessary clothing and place the person on his or her side to expose as much skin surface to the air as possible. \n" +
                    "\nStep 3: Cool the person's entire body by sponging or spraying cold water, and fan the person to help lower the person's body temperature. " +
                    "\nWatch for signs of rapidly progressing heatstroke, such as seizure, unconsciousness for longer than a few seconds, and moderate to severe difficulty breathing. \n" +
                    "\nStep 4: Apply ice packs over as much of the body as you can. \n" +
                    "\nStep 5: Check the person's rectal temperature, and try to cool it to 102°F (39°C) or lower as soon as possible. The longer the body is at a high temperature, " +
                    "\nthe more serious the illness and the more likely it is that complications will develop. Temperatures taken by mouth or in the ear are not accurate in this emergency situation. \n" +
                    "\nStep 6: If a person has stopped breathing, begin CPR. \n" +
                    "\nStep 7: Do not give any medicine to reduce a high body temperature that can occur with heatstroke. Medicines may cause problems because of the body's response to heatstroke.\n" +
                    "\nStep 8: If the person is awake and alert enough to swallow, give the person fluids [32 fl oz (1 L) to 64 fl oz (2 L) over 1 to 2 hours] for hydration. Most people with heatstroke " +
                    "\nhave an altered level of consciousness and cannot safely be given fluids to drink. You may have to help. Make sure the person is sitting up enough so that he or she does not choke. \n" +
                    "\nHow to administer CPR \nStep 1: Push hard, push fast.Place your hands, one on top of the other, in the middle of the chest.Use your body weight to help you administer compressions that are at least 2 inches " +
                    "\ndeep and delivered at a rate of at least 100 compressions per minute. \n \nStep 2: Deliver rescue breaths. With the person's head tilted back slightly and the chin lifted, pinch the nose shut and place your mouth over the person's mouth to make a complete seal." +
                    "\nBlow into the person's mouth to make the chest rise. Deliver two rescue breaths, then continue compressions.\n \nSpecial Note: If the chest does not rise with the initial rescue breath, re-tilt the head before delivering the second breath. \nIf the chest " +
                    "doesn't rise with the second breath, the person may be choking. \nAfter each subsequent set of 100 chest compressions, and before attempting breaths, look for an object and, if seen, remove it. \n \nStep 3: Continue CPR steps. Keep performing cycles of chest " +
                    "compressions and breathing until the person exhibits signs of life, such as breathing, an AED becomes available, or \nEMS or a trained medical responder arrives on scene."; 

            else if (userValue == "bjm")
                message = "\nBone, joint, and muscle injury = Cold packs, bandages, and broken bone sling \n" +
                    "\nStep 1: Keep the casualty comfortable i.e. have them rest. " +
                    "\nStep 2: Immobilize the injured body part in the position found and never move the injury." +
                    "\nStep 3: Apply an cold compress over the area for about 15 minutes every hour except for open fractures." +
                    "\nElevate the injured body part, but only if it does not cause further pain or discomfort." +
                    "\nTreat for shock." +
                    "\nstay with casualty until medical professionals arrive.";

            // The help section will display the meanings of all the codes snippets 
            else if (userValue == "help")
                message = "ami = Heart Attack " +
                    "\nhss = Hyperglycemia (low blood pressure) " +
                    "\naas = Anaphylactic Shock (Allergic Reaction) " +
                    "\nll = Severed Limb " +
                    "\nopw = Open Chest Wound " +
                    "\ncva = Cerebrovascular Accident (Stroke) " +
                    "\n23b = 2nd & 3rd Degree Burns " +
                    "\nod = Drug Overdose " +
                    "\nht = Heat Realted Injury " +
                    "\nlti = Bone, joint, and muscle injury ";
            else

            {
                message = "Incorrect input.  Please re-enter code: ";
                //message = message + "Incorrect input. Please re-enter code: ";
                message += "Hit enter to restart.";
            }

            Console.WriteLine(message);
            Console.ReadLine();


            /*
            Console.WriteLine("Chris' Door Game");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "Boat" : "Strand of lint";

            //Console.Write("you won a ");
            //Console.Write(message);
            //Console.Write(".");

            //Console.WriteLine("You Won a {0}.", message);
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
            */

        }
    }
}