namespace ADarkForest

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Html

[<JavaScript>]
module Choice =
    let display = Var.Create "You wake up in a dark forest. Your vision is blurry and you are famished."

    let leftDisplay = [
        "You see a path leading left. Do you go left?"
        "You walk left and find a friendly talking squirrel. The squirrel offers you a nut. Do you take it?"
        "You take the nut. The squirrel thanks you and scurries away. Do you continue down the path?"
        "A gentle breeze rustles the leaves, whispering secrets in your ear. Do you follow the path deeper into the woods, or do you look for a hidden path leading elsewhere?"
        "You focus on the whispers of the wind. Does it seem to beckon you in a specific direction?"
        "You trust the wind's guidance and head in that direction. The path ahead seems less clear. Do you press on or turn back?"
        "Suddenly, you hear a loud rustling sound behind you. Do you turn around to investigate or keep walking?"
        "Seeing nothing on the ground, you decide to climb a nearby tree for a better look. Do you climb high into the branches or stay low for a quick escape?"
        "Curious, you examine the nut the squirrel offered. Does it appear normal or is there something unusual about it?"
        "Feeling grateful, you offer the squirrel something from your backpack. Do you offer it food, water, or something else?"
        "You notice animal tracks in the dirt. Do you follow the tracks or continue on the main path?"
        "Feeling cheerful, you decide to sing a song as you walk. Does your song attract any attention?"
        "Feeling peckish, you decide to search for berries or edible plants. Do you find anything?"
        "Following the wind's guidance, you come across a large, flat rock. Do you carve a symbol on the rock or leave it untouched?"
        "Feeling a strange connection to the woods, you try talking to the trees. Do they respond in any way?"
        "As the sun begins to set, you decide to build a shelter for the night. Do you build a simple lean-to or something more elaborate?"
        "As you turn to investigate the rustling, you sense a strange presence nearby. Do you call out or stay hidden?"
        "You decide to leave a small gift on a branch as a thank you for the lookout point. Do you leave food, a shiny object, or something else?"
        "The wind carries the faint scent of something sweet. Could it be berries or wildflowers?"
        "As you walk, you spot a curious glint of light reflecting off something in the distance. Do you investigate?"
        "You hear the sound of trickling water. Perhaps there's a hidden stream nearby?"
        "The path forks again. This time, there's a weathered signpost pointing in two different directions. Do you follow the sign or forge your own path?"
        "Lost in thought, you almost miss a small, colorful bird perched on a branch. It seems to be watching you intently. Do you greet the bird?"
        "The air grows noticeably cooler. Is night approaching, or is there something magical at play?"
        "You feel a strange tingling sensation on your skin. Is it just the wind, or something more?"
        "A memory surfaces from your past. Does it offer any clues about your current situation?"
        "The forest seems to hold its breath. An unsettling silence descends upon you. Do you press on or turn back?"
        "You hear a low, mournful howl echoing through the trees. Does it send chills down your spine?"
        "A mysterious fog begins to roll in, obscuring your path. Do you wait for it to clear or proceed carefully?"
        "You come across a small clearing with a circle of stones. Do you investigate or avoid it?"
        "You notice a flickering light in the distance. Do you head towards it or stay where you are?"
        "A soft melody drifts through the air. Do you follow the sound or ignore it?"
        "You find an old, weathered journal on the ground. Do you read it or leave it alone?"
        "The scent of fresh pine fills the air. Does it make you feel at ease or on edge?"
        "You hear a distant, haunting lullaby. Do you search for its source or continue on your path?"
        "A pair of glowing eyes peer at you from the darkness. Do you approach or retreat?"
        "You feel a sudden burst of energy. Do you use it to explore further or save it for later?"
        "A sense of familiarity washes over you as you walk. Do you recall why this place feels known?"
        "You notice a tree with strange carvings. Do you investigate their meaning or move on?"
        "You come upon a sparkling stream. Do you stop to drink or continue walking?"
        "A flash of light catches your eye from the ground. Do you dig to uncover its source?"
        "The woods seem to whisper your name. Do you call back or remain silent?"
        "You feel a presence behind you. Do you turn around or quicken your pace?"
        "A fallen log blocks your path. Do you climb over it or find another way around?"
        "You come across an old, abandoned cabin. Do you enter or continue on your way?"
        "You hear a soft giggle nearby. Do you investigate or ignore it?"
        "You find a mysterious amulet on the ground. Do you pick it up or leave it?"
        "You find a hidden alcove with strange symbols on the walls. Do you examine them or move on?"
        "A rabbit hops across your path and stops to look at you. Do you follow it or stay on your path?"
        "You hear distant chanting. Do you follow the sound or avoid it?"
        "A thick vine hangs from a tall tree. Do you climb it or leave it alone?"
        "You find a small pond with crystal-clear water. Do you stop to drink or move on?"
        "A fallen leaf drifts gently to the ground. Do you pick it up or keep walking?"
        "You come across an old, crumbling stone wall. Do you climb over it or walk around it?"
        "The air smells of fresh rain. Do you seek shelter or enjoy the weather?"
        "You hear the sound of laughter coming from ahead. Do you investigate or avoid it?"
        "A narrow, overgrown trail branches off the main path. Do you take it or stay on your course?"
        "You find a piece of parchment with strange writing. Do you try to read it or ignore it?"
        "A deer stands in the clearing, watching you. Do you approach it or stay still?"
        "You notice a peculiar rock formation. Do you examine it closely or move on?"
        "The forest floor feels soft beneath your feet. Do you sit and rest or keep walking?"
        "You hear a babbling brook nearby. Do you follow the sound or stay on the path?"
        "A colorful butterfly flutters past. Do you follow it or let it go?"
        "You find an old, rusty lantern. Do you take it with you or leave it?"
        "The canopy above opens up to reveal the sky. Do you stop to stargaze or continue walking?"
        "You hear a rustling in the bushes. Do you investigate or ignore it?"
        "A gentle rain begins to fall. Do you seek shelter or continue walking?"
        "You find a carved wooden totem. Do you examine it or move on?"
        "A cool breeze caresses your face. Do you follow the direction it's coming from or stay on your path?"
        "You notice a trail of glowing mushrooms. Do you follow them or avoid them?"
        "You find a small, ornate box half-buried in the ground. Do you open it or leave it?"
        "A distant bell chimes softly. Do you follow the sound or ignore it?"
        "You see a flash of movement in the trees. Do you investigate or stay on your path?"
        "A soft glow emanates from a nearby grove. Do you explore it or keep walking?"
        "You find an old, weathered signpost. Do you follow its directions or choose your own path?"
        "A strange, sweet fragrance fills the air. Do you search for its source or ignore it?"
        "You hear a soft humming nearby. Do you follow the sound or stay on the path?"
        "A shadowy figure crosses your path and disappears. Do you chase it or let it go?"
        "You chase after him but he turns out to be a ghastly figure you cannot make out. Do you attempt to fight it?"
        "You died."
        ]

    let rightDisplay = [
        "Off the beaten path to the right you hear footsteps. Do you go right?"
        "You head right and encounter a grumpy troll. The troll demands a riddle be answered. Do you answer?"
        "You answer. The troll asks you a riddle, 'What sets beyond the stars but isn't part of it?'"
        "You refuse to answer the riddle. Do you try to outsmart the troll with a question of your own, or do you attempt to fight your way past?"
        "The troll seems impressed by your refusal. He offers you a cryptic clue: 'Seek the whispering stones by the moonlight.' What do you do?"
        "Instead of answering the riddle, you offer the troll something from your backpack. Do you offer him food, a shiny object, or something else?"
        "Feeling bold, you challenge the troll to a contest of strength, wit, or magic (choose one).  Do you accept the challenge?"
        "Instead of answering the riddle or offering a gift, you try to negotiate with the troll. What do you offer him in exchange for passage?"
        "Hoping to lighten the mood, you try to tell the troll a joke. Does it make him laugh?"
        "Curious about the footsteps, you ask the troll who made them. Does he answer your question?"
        "Hoping to confuse the troll, you pretend you don't understand the riddle. Does he buy your act?"
        "The troll guards a rickety bridge. You decide to inspect it for weaknesses. Do you find a way to bypass the troll or does he catch you?"
        "Trying a different approach, you appeal to the troll's emotions. Do you tell him a sad story or try to make him feel sympathy?"
        "Sensing the troll's loneliness, you offer to help him with something. Does he accept your offer?"
        "The troll refuses your chosen contest. He offers you a challenge of speed, endurance, or illusion. Do you accept his new challenge?"
        "Curious about the troll, you ask him for his name. Does he reveal it to you?"
        "Following the troll's clue, you wait for nightfall and search for the whispering stones by moonlight. Do you find them?"
        "A peculiar, glowing flower catches your eye. You've never seen anything like it before. Do you touch it or admire it from afar?"
        "The wind carries the faint sound of music. Does it lead you closer or further down the path?"
        "You stumble upon a clearing bathed in sunlight. In the center stands a weathered statue, moss-covered and mysterious. Do you approach it?"
        "A feeling of deja vu washes over you. Have you been here before? Does your memory offer any clues?"
        "You spot a set of strange symbols carved into a nearby tree. Do you try to decipher them?"
        "The forest air crackles with an unseen energy. Do you sense danger or something more mystical?"
        "A sudden gust of wind whips through the trees, scattering leaves and sending shivers down your spine. Do you seek shelter or press on?"
        "You hear a high-pitched cry echoing through the woods. Does it sound familiar?"
        "A sense of urgency fills you. Do you quicken your pace or follow your initial plan?"
        "The path narrows, squeezing between towering trees. Does sunlight struggle to penetrate the dense canopy above?"
        "You notice a faint trail branching off the main path. Do you follow it or stay on the main path?"
        "A strange, sweet smell fills the air. Do you investigate its source or ignore it?"
        "You find an old, rusted key half-buried in the dirt. Do you take it with you or leave it?"
        "A gentle, melodic humming catches your attention. Do you follow the sound or stay put?"
        "You come across a small, abandoned campsite. Do you search the campsite or move on?"
        "A curious fox crosses your path and pauses to look at you. Do you approach it or keep your distance?"
        "You find a piece of torn fabric caught on a branch. Do you investigate further or leave it alone?"
        "A sudden, eerie silence falls over the forest. Do you press on cautiously or turn back?"
        "You spot a faint, glowing light through the trees. Do you head towards it or avoid it?"
        "A distant rumble of thunder suggests a storm is coming. Do you seek shelter or continue on your way?"
        "You come across an old, twisted tree with gnarled branches. Do you investigate it or move on?"
        "The ground beneath your feet feels different, almost hollow. Do you dig or continue walking?"
        "You find a strange, ornate box buried in the ground. Do you open it or leave it alone?"
        "A rustling in the bushes catches your attention. Do you investigate or stay on the path?"
        "You come across a shimmering portal. Do you step through it or avoid it?"
        "A chill runs down your spine as you hear a distant scream. Do you follow the sound or stay where you are?"
        "You find an old map on the ground. Do you try to follow it or ignore it?"
        "A large boulder blocks your path. Do you climb over it or find a way around?"
        "You notice a hidden door in the side of a hill. Do you open it or move on?"
        "A gentle breeze carries the sound of laughter. Do you follow it or ignore it?"
        "You find a set of footprints leading off the path. Do you follow them or stay on the main trail?"
        "The air grows warmer as you approach a clearing. Do you enter or stay in the shade of the trees?"
        "You see a flicker of movement out of the corner of your eye. Do you investigate or keep going?"
        "A feeling of unease settles over you. Do you press on or turn back?"
        "You come across an ancient ruin hidden in the forest. Do you explore it or leave it alone?"
        "A soft, glowing orb floats in the air before you. Do you reach out to touch it or watch from a distance?"
        "You hear a strange chant coming from deeper in the woods. Do you follow the sound or stay on your path?"
        "You find an abandoned backpack with supplies. Do you take it or leave it?"
        "A sudden flash of lightning illuminates a hidden path. Do you take it or stick to the main trail?"
        "You notice a small, hidden pond with crystal-clear water. Do you stop to drink or move on?"
        "A pair of glowing eyes peer at you from the darkness. Do you approach or retreat?"
        "You find a mysterious pendant lying on the ground. Do you pick it up or leave it?"
        "A strange fog begins to roll in, obscuring your path. Do you wait for it to clear or proceed carefully?"
        "You come across a small clearing with a circle of stones. Do you investigate or avoid it?"
        "You notice a flickering light in the distance. Do you head towards it or stay where you are?"
        "A soft melody drifts through the air. Do you follow the sound or ignore it?"
        "You find an old, weathered journal on the ground. Do you read it or leave it alone?"
        "The scent of fresh pine fills the air. Does it make you feel at ease or on edge?"
        "You hear a distant, haunting lullaby. Do you search for its source or continue on your path?"
        "A pair of glowing eyes peer at you from the darkness. Do you approach or retreat?"
        "You feel a sudden burst of energy. Do you use it to explore further or save it for later?"
        "A sense of familiarity washes over you as you walk. Do you recall why this place feels known?"
        "You notice a tree with strange carvings. Do you investigate their meaning or move on?"
        "You come upon a sparkling stream. Do you stop to drink or continue walking?"
        "A flash of light catches your eye from the ground. Do you dig to uncover its source?"
        "The woods seem to whisper your name. Do you call back or remain silent?"
        "You feel a presence behind you. Do you turn around or quicken your pace?"
        "A fallen log blocks your path. Do you climb over it or find another way around?"
        "You finally see a opening out of the forest. Do you take it?"
        "You died."
        ]

    let mutable leftCounter = 0
    let mutable rightCounter = 0
 
    let handleEvent (choice: int) =
        match choice with
        | 0 ->
            display.Set(leftDisplay.[leftCounter])
            if leftDisplay[leftCounter] <> "You Died." then
                leftCounter <- leftCounter + 1
        | _ ->
            display.Set(rightDisplay.[rightCounter])
            if rightDisplay[rightCounter] <> "You Died." then
                rightCounter <- rightCounter + 1

    [<SPAEntryPoint>]
    let Main () =
        div [] [
            h1 [] [text display.V]
            button [on.click (fun _ _ -> handleEvent 0)] [text "No"]
            button [on.click (fun _ _ -> handleEvent 1)] [text "Yes"]
        ]
        |> Doc.RunById "main"
