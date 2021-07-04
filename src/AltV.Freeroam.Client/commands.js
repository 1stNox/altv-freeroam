import * as alt from 'alt-client';

// alt:V Events
alt.onServer("Command:Pos:Print", (pos) => {
    alt.log('X: ' + pos.x + ' Y: ' + pos.y + ' Z: ' + pos.z);
});

alt.onServer("Command:Rot:Print", (rot) => {
    alt.log('Roll: ' + rot.x + ' Pitch: ' + rot.y + ' Yaw: ' + rot.z);
});