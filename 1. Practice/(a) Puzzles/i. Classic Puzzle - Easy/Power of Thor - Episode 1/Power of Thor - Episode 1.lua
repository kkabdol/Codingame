-- Seonghyeon Choe
-- schoe@seonghyeonchoe.com
-- 2021

-- lightX: the X position of the light of power
-- lightY: the Y position of the light of power
-- initialTX: Thor's starting X position
-- initialTY: Thor's starting Y position
next_token = string.gmatch(io.read(), "[^%s]+")
lightX = tonumber(next_token())
lightY = tonumber(next_token())
initialTX = tonumber(next_token())
initialTY = tonumber(next_token())

-- game loop
while true do
    remainingTurns = tonumber(io.read()) -- The remaining amount of turns Thor can move. Do not remove this line.
    
    command = ""
    if initialTY > lightY then
        command = command .. "N"
        initialTY = initialTY - 1
    elseif initialTY < lightY then
        command = command .. "S"
        initialTY = initialTY + 1
    end

    if initialTX > lightX then
        command = command .. "W"
        initialTX = initialTX - 1
    elseif initialTX < lightX then
        command = command .. "E"
        initialTX = initialTX + 1
    end
    
    print(command)
end